var uri = "http://raceplaceangular.azurewebsites.net/api/Entrants";

$(document).ready(function () {
    // Send an AJAX request
    $.getJSON(uri)
        .done(function (data) {
            // On success, 'data' contains a list of products.
            $.each(data.value, function (key, value) {
                // Add a list item for the product.
                $('<li>', { text: formatItem(value) }).appendTo($('#entrants'));
            });
        });
});

function formatItem(value) {
    return value.City + ': ' + value.FullName;
}


$(function () {
    var dataSource = new kendo.data.DataSource({
        type: "odata",
        transport: {
            read: {
                url: "http://raceplaceangular.azurewebsites.net/api/IndividualResults",
                dataType: "json"
            },
        },
        schema: {
            data: function (data) {
                return data["value"];
            },
            total: function (data) {
                return data["odata.count"];
            },
            model: {
                fields: {
                    IndividualResultId: { type: "int" },
                    FullName: { type: "string" },
                }
            }
        },
        pageSize: 10,
        serverPaging: true,
        serverFiltering: true,
        serverSorting: true,
    });

    $("#grid").kendoGrid({
        dataSource: dataSource,
        filterable: true,
        sortable: true,
        pageable: {
            refresh: true,
            pageSizes: true,
            buttonCount: 10
        },

        groupable: true,
        scrollable: true,
        reorderable: true,
        resizable: true,
        columnMenu: true,
        //detailTemplate: kendo.template($("#template").html()),

        columns: [{
            field: "IndividualResultId",
            // width:140
            filterable: false,
            hidden: true,
        }, {
            field: "FullName",
        }, {
            field: "OverallTime",
            type: "date",
            format: "{0:MM/dd/yyyy hh:mm:ss tt}"
        }]
    });
});

