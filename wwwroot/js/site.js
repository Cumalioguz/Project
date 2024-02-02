function sendAjaxRequest(modelname) {
    $.ajax({
        type: "POST",
        url: "/Entity/GetModels",
        data: { modelName: modelname },
        success: function (data) {
            console.log(data);
        },
        error: function (error) {
            console.log(error);
        }
    });
}

function sendAjaxRequestdetail(modelname, entityId,formname) {
    $.ajax({
        type: "POST",
        url: "/Entity/GetEntityDetail",
        data: { modelName: modelname, entityId: entityId },
        success: function (data) {
            fillFormWithData(formname, data);
            console.log(data);
        },
        error: function (error) {
            console.log(error);
        }
    });

}
function fillFormWithData(divId, data) {
    $("#" + divId + " input").each(function () {
        var attributeName = $(this).attr("name");
        console.log("Attribute Name:", attributeName);  // Konsola attribute adını yazdır

        if (data.hasOwnProperty(attributeName)) {
            console.log("Attribute Value:", data[attributeName]);  // Konsola attribute değerini yazdır

            // Gelen veri içinde ilgili özellik (attributeName) varsa, input değerini bu veriyle doldur
            $(this).val(data[attributeName]);
        } else {
            console.log("Attribute not found in data.");  // Konsola özellik bulunamadı mesajını yazdır
        }
    });
}


function AjaxRequestdelete(modelname, entityId) {
    $.ajax({
        type: "POST",
        url: "/Entity/DeleteEntity",
        data: { modelName: modelname, entityId: entityId }, // Örnek olarak model adı "Product" ve ID 1
        success: function (data) {
            console.log(data);
        },
        error: function (error) {
            console.log(error);
        }
    });

}

function updateEntity(divId) {
    var updatedEntity = {};
    $("#" + divId + " input").each(function () {
        var attributeName = $(this).attr("name");
        var attributeValue = $(this).val();
        updatedEntity[attributeName] = attributeValue;
    });

    // Ajax isteği ile güncelleme işlemini gerçekleştirme
    $.ajax({
        type: "POST",
        url: "/Entity/UpdateEntity",
        contentType: "application/json", // Content-Type'ı belirt
        data: JSON.stringify({
            modelName: divId.replace("UpdateForm", ""),
            entityId: 1,
            updatedColumns: updatedEntity
        }),
        success: function (data) {
            console.log(data);
        },
        error: function (error) {
            console.log(error);
        }
    });
}