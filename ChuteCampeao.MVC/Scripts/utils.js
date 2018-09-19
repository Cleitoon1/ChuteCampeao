Utils = {
    DataTablesUtils: {
        renderDataTable: function (target, columnsSet, dataSet) {
            $(target).DataTable({
                "responsive": true,
                "destroy": true,
                "data": dataSet,
                "columns": columnsSet,
                "language": dataTablePortugues(),
                "lengthMenu": [[10, 20, 50, 100, -1], [10, 20, 50, 100, "Todos"]],
            });

        },
        renderAtivoValue: function (data, type, row, meta) {
            if (data != undefined && data != null && data != "")
                return (data == true ? "Ativo" : "Inativo");
            else
                return "";
        },
        renderDataFormatValue: function (data, format) {
            if (data != undefined && data != null && data != "") {
                var s = data.replace('/Date(', '');
                s = s.replace(')/', '');
                s = moment(data, format.toUpperCase()).toDate();
                return (s.getDate() < 10 ? '0' + s.getDate() : s.getDate()) + '/' + ((s.getMonth() + 1) < 10 ? '0' + (s.getMonth() + 1) : (s.getMonth() + 1)) + '/' + s.getFullYear();
            }
            else
                return "";
        },
        renderDataValue: function (data, type, row, meta) {
            if (data != undefined && data != null && data != "") {
                var s = data.replace('/Date(', '');
                s = s.replace(')/', '');
                s = new Date(parseInt(s));
                return (s.getDate() < 10 ? '0' + s.getDay() : s.getDate()) + '/' + ((s.getMonth() + 1) < 10 ? '0' + (s.getMonth() + 1) : (s.getMonth() + 1)) + '/' + s.getFullYear();
            }
            else
                return "";
        },
        getObjLineDataTable: function (table, row) {
            return table.DataTable().row(row).data();
        }
    },
    DatePickerUtils: {
        onlyDatePtBr: function () {
            return {
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                changeYear: true,
                dayNames: ['Domingo', 'Segunda', 'Terça', 'Quarta', 'Quinta', 'Sexta', 'Sábado'],
                dayNamesMin: ['Dom', 'Seg', 'Ter', 'Qua', 'Qui', 'Sex', 'Sáb', 'Dom'],
                dayNamesShort: ['Dom', 'Seg', 'Ter', 'Qua', 'Qui', 'Sex', 'Sáb', 'Dom'],
                monthNames: ['Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho', 'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro'],
                monthNamesShort: ['Jan', 'Fev', 'Mar', 'Abr', 'Mai', 'Jun', 'Jul', 'Ago', 'Set', 'Out', 'Nov', 'Dez'],
                nextText: 'Proximo',
                prevText: 'Anterior'
            };
        }
    }
}




function dataTablePortugues() {
    return {
        "sEmptyTable": "Nenhum registro encontrado",
        "sInfo": "Mostrando de _START_ até _END_ de _TOTAL_ registros",
        "sInfoEmpty": "",
        "sInfoFiltered": "(Filtrados de _MAX_ registros)",
        "sInfoPostFix": "",
        "sInfoThousands": ".",
        "sLengthMenu": "_MENU_ Resultados por página",
        "sLoadingRecords": "Carregando...",
        "sProcessing": "Processando...",
        "sZeroRecords": "Nenhum registro encontrado",
        "sSearch": "Pesquisar",
        "oPaginate": {
            "sNext": "Próximo",
            "sPrevious": "Anterior",
            "sFirst": "Primeiro",
            "sLast": "Último"
        },
        "oAria": {
            "sSortAscending": ": Ordenar colunas de forma ascendente",
            "sSortDescending": ": Ordenar colunas de forma descendente"
        }
    };
}