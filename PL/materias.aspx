<%@ Page Title="Materias" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="materias.aspx.cs" Inherits="PL.Materias" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!--HEADER START-->
    <div class="container">
        <h3>Seguimiento de Materias</h3>
    </div>
    <!--HEADER END-->


    <!--IMPORT-->
    <div class="jumbotron">
        <!--TARGET-->
        <table class="table table-hover" id="Table1" runat="server"></table>


        <input class="btn btn-success" type="button" value="importar" runat="server" id="importar" onserverclick="Importar_Click" />

    </div>








    <!--INPUT START-->
    <style>
        #container {
            height: 400px;
        }

        .highcharts-figure, .highcharts-data-table table {
            min-width: 310px;
            max-width: 800px;
            margin: 1em auto;
        }

        #datatable {
            font-family: Verdana, sans-serif;
            border-collapse: collapse;
            border: 1px solid black;
            margin: 10px auto;
            text-align: center;
            width: 100%;
            max-width: 500px;
        }

            #datatable caption {
                padding: 1em 0;
                font-size: 1.2em;
                color: #555;
            }

            #datatable th {
                font-weight: 600;
                padding: 0.5em;
            }

            #datatable td, #datatable th, #datatable caption {
                padding: 0.5em;
            }

            #datatable thead tr, #datatable tr:nth-child(even) {
                background: black;
            }

            #datatable tr:hover {
                background: #f1f7ff;
            }
    </style>

    <script>
        function showGraph() {

            var graph = document.getElementById("grafico");


            var displaySetting = graph.style.display;

            if (displaySetting == 'block') {

                graph.style.display = 'none';
                clockButton.innerHTML = 'Mostrar Grafica';
            }
            else {
                graph.style.display = 'block';
                clockButton.innerHTML = 'Ocultar Grafica';
            }
        }

    </script>

    <script src="https://code.highcharts.com/highcharts.js"></script>
    <script src="https://code.highcharts.com/modules/data.js"></script>
    <script src="https://code.highcharts.com/modules/exporting.js"></script>
    <script src="https://code.highcharts.com/modules/accessibility.js"></script>

    <div class="jumbotron">
        <!--TARGET-->



        

        <div id="grafico">
            <figure class="highcharts-figure">
                <div id="container"></div>
                <p class="highcharts-description">
                </p>

                <table id="datatable" style="display: none">
                    <thead>
                        <tr>
                            <th></th>
                            <th>Mario Chaves</th>
                            <th>Sergio Chaves</th>
                            <th>Andres Chaves</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th>Ingles I</th>
                            <td>97</td>
                            <td>0</td>
                            <td>0</td>
                        </tr>
                        <tr>
                            <th>Matematica I</th>
                            <td>86</td>
                            <td>0</td>
                            <td>0</td>
                        </tr>
                        <tr>
                            <th>Matematica II</th>
                            <td>92</td>
                            <td>0</td>
                            <td>0</td>
                        </tr>
                        <tr>
                            <th>Estadistica I</th>
                            <td>92</td>
                            <td>0</td>
                            <td>0</td>
                        </tr>
                        <tr>
                            <th>Contabilidad I</th>
                            <td>75</td>
                            <td>0</td>
                            <td>0</td>
                        </tr>
                        <tr>
                            <th>Programacion I</th>
                            <td>100</td>
                            <td>0</td>
                            <td>0</td>
                        </tr>
                        <tr>
                            <th>Bases de Datos</th>
                            <td>100</td>
                            <td>0</td>
                            <td>0</td>
                        </tr>
                        <tr>
                            <th>Programacion II</th>
                            <td>100</td>
                            <td>0</td>
                            <td>0</td>
                        </tr>
                        <tr>
                            <th>Programacion III</th>
                            <td>100</td>
                            <td>0</td>
                            <td>0</td>
                        </tr>
                        <tr>
                            <th>Logica y Algoritmos</th>
                            <td>98</td>
                            <td>0</td>
                            <td>0</td>
                        </tr>
                        <tr>
                            <th>Administracion General</th>
                            <td>100</td>
                            <td>0</td>
                            <td>0</td>
                        </tr>
                        <tr>
                            <th>Utilizacion del Software</th>
                            <td>100</td>
                            <td>0</td>
                            <td>0</td>
                        </tr>
                        <tr>
                            <th>Organizacion de Estructuras</th>
                            <td>97</td>
                            <td>0</td>
                            <td>0</td>
                        </tr>
                        <tr>
                            <th>Organizacion de Computadoras</th>
                            <td>92</td>
                            <td>0</td>
                            <td>0</td>
                        </tr>
                        <tr>
                            <th>Introduccion a la Informatica</th>
                            <td>81</td>
                            <td>0</td>
                            <td>0</td>
                        </tr>
                        <tr>
                            <th>Organizacion de Archivos y Estructuras</th>
                            <td>100</td>
                            <td>0</td>
                            <td>0</td>
                        </tr>

                    </tbody>
                </table>
            </figure>
        </div>
    </div>



    <script type="text/javascript">
        Highcharts.chart('container', {
            data: {
                table: 'datatable'
            },
            chart: {
                type: 'column'
            },
            title: {
                text: 'Representacion de los datos de la Tabla HTML'
            },
            yAxis: {
                allowDecimals: false,
                title: {
                    text: 'Nota'
                }
            },
            tooltip: {
                formatter: function () {
                    return '<b>' + this.series.name + '</b><br/>' +
                        this.point.y + ' ' + this.point.name.toLowerCase();
                }
            }
        });

    </script>
    <!--INPUT END-->
</asp:Content>





