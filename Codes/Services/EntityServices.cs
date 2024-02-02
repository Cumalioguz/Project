using Microsoft.EntityFrameworkCore;
using Project.Controllers;
using Project.Models.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;

namespace Project.Codes.Services
{
    public interface IEntityService
    {
        List<object> GetEntities(string modelName);
        object GetEntityDetail(string modelName, int entityId);
        bool DeleteEntity(string modelName, int entityId);
        bool UpdateEntity(string modelName, int entityId, Dictionary<string, object> updatedEntity);
    }

    public class EntityService : IEntityService
    {
        private readonly rehabilitasyonContext _dbContext;

        public EntityService(rehabilitasyonContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<object> GetEntities(string modelName)
        {
            var dbSetProperty = _dbContext.GetType().GetProperties()
                .FirstOrDefault(p =>
                    p.PropertyType.IsGenericType &&
                    p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>) &&
                    p.PropertyType.GetGenericArguments().FirstOrDefault()?.Name == modelName);

            if (dbSetProperty != null)
            {
                var dbSet = (IEnumerable<object>)dbSetProperty.GetValue(_dbContext);
                return dbSet.ToList();
            }

            return null;
        }

        public object GetEntityDetail(string modelName, int entityId)
        {
            var dbSetProperty = _dbContext.GetType().GetProperties()
                .FirstOrDefault(p =>
                    p.PropertyType.IsGenericType &&
                    p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>) &&
                    p.PropertyType.GetGenericArguments().FirstOrDefault()?.Name == modelName);

            if (dbSetProperty != null)
            {
                var dbSet = (IEnumerable<object>)dbSetProperty.GetValue(_dbContext);

                if (dbSet != null)
                {
                    // entityType'i al
                    Type entityType = dbSetProperty.PropertyType.GetGenericArguments().First();

                    // dbSet içinde Id'si entityId olan veriyi bul
                    var entity = dbSet
                        .Cast<dynamic>()  // Dynamic olarak cast et
                        .FirstOrDefault(x => x.Id == entityId);

                    return entity;
                }
            }

            return null;
        }

        public bool DeleteEntity(string modelName, int entityId)
        {
            var dbSetProperty = _dbContext.GetType().GetProperties()
                .FirstOrDefault(p =>
                    p.PropertyType.IsGenericType &&
                    p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>) &&
                    p.PropertyType.GetGenericArguments().FirstOrDefault()?.Name == modelName);

            if (dbSetProperty != null)
            {
                var dbSet = (IEnumerable<object>)dbSetProperty.GetValue(_dbContext);

                if (dbSet != null)
                {
                    // entityType'i al
                    Type entityType = dbSetProperty.PropertyType.GetGenericArguments().First();

                    // dbSet içinde Id'si entityId olan veriyi bul
                    var entity = dbSet
                        .Cast<dynamic>()  // Dynamic olarak cast et
                        .FirstOrDefault(x => x.Id == entityId);

                    if (entity != null)
                    {
                        // entity'yi Remove ile işaretleyip, SaveChanges ile değişiklikleri kaydet
                        _dbContext.Remove(entity);
                        int affectedRows = _dbContext.SaveChanges();

                        // Eğer etkilenen kayıt sayısı 1 ise, başarıyla silinmiştir
                        return affectedRows == 1;
                    }
                }
            }

            // Eğer yukarıdaki koşullar sağlanmazsa, silme işlemi başarısızdır
            return false;
        }


        public bool UpdateEntity(string modelName, int entityId, Dictionary<string, object> updatedEntity)
        {
            try
            {
                var dbSetProperty = _dbContext.GetType().GetProperties()
                    .FirstOrDefault(p =>
                        p.PropertyType.IsGenericType &&
                        p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>) &&
                        p.PropertyType.GetGenericArguments().FirstOrDefault()?.Name == modelName);

                if (dbSetProperty != null)
                {
                    var dbSet = (IEnumerable<object>)dbSetProperty.GetValue(_dbContext);

                    if (dbSet != null)
                    {
                        Type entityType = dbSetProperty.PropertyType.GetGenericArguments().First();

                        // Id'si entityId olan entity'yi çek
                        var entity = dbSet.Cast<dynamic>().FirstOrDefault(x => x.Id == entityId);

                        if (entity != null)
                        {
                            // Entity'nin tüm property'lerini al
                            var properties = entityType.GetProperties();

                            // Her bir property için döngü
                            // updatedEntity içindeki JsonElement'leri uygun türde değerlere dönüştür
                            var convertedUpdatedEntity = updatedEntity.ToDictionary(
                                kvp => kvp.Key,
                                kvp => kvp.Value is JsonElement jsonElement ? ConvertJsonElement(jsonElement) : kvp.Value
                            );

                            // Dönüştürülmüş updatedEntity'yi kullanarak güncelleme işlemi
                            foreach (var property in properties)
                            {
                                var propertyName = property.Name;

                                if (convertedUpdatedEntity.ContainsKey(propertyName))
                                {
                                    var propertyValue = convertedUpdatedEntity[propertyName];

                                    // Dönüşüm işlemini gerçekleştir
                                    try
                                    {
                                        var convertedValue = Convert.ChangeType(propertyValue, property.PropertyType);
                                        property.SetValue(entity, convertedValue);
                                    }
                                    catch (InvalidCastException)
                                    {
                                        // Dönüşüm başarısız olduysa, uygun bir strateji uygula
                                        return false;
                                    }
                                }
                            }

                            // Geri kalan güncelleme işlemleri burada devam eder


                            // Entity'nin durumunu Modified olarak işaretle
                            _dbContext.Entry(entity).State = EntityState.Modified;

                            // Değişiklikleri kaydet
                            _dbContext.SaveChanges();

                            return true;
                        }
                        else
                        {
                            // Belirtilen kimlikle entity bulunamadı
                            return false;
                        }
                    }
                }

                // Eğer yukarıdaki koşullar sağlanmazsa, güncelleme işlemi başarısızdır
                return false;
            }
            catch (Exception)
            {
                // Hata durumunda false dönebilir veya hata mesajını loglayabilirsiniz.
                return false;
            }
        }





        private static object ConvertJsonElement(JsonElement jsonElement)
        {
            return jsonElement.ValueKind switch
            {
                JsonValueKind.String => jsonElement.GetString(),
                JsonValueKind.Number => jsonElement.GetDecimal(),
                // Diğer türler için gerekli dönüşümleri buraya ekleyebilirsiniz
                _ => null,
            };
        }












    }
}
