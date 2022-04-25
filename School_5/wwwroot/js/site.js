
let App = {

        Core: {
            CreateTable: function(id) {
                $("#" + id).DataTable({
                    "language": {
                        "url": "//cdn.datatables.net/plug-ins/1.10.19/i18n/Spanish.json"
                    }
                });           
        },
        Data: {},
        Views: {
            Estudiantes:{
                Table: {
                    OnLoad: function() {
                        App.Core.CreateTable("tablaEstudiantes")
                    }
                },
                File: {
                    OnLoad: function() {}
                },
            }
        },
}