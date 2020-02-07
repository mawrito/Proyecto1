$(document).ready(function () {

    var specialElementHandlers = {
        "#editor": function (element, renderer) {
            return true;
        }
    };

    $("#Button6").click(function () {

        var doc = new jsPDF();

        doc.fromHTML($("#target").html(), 15, 15, {
            "width": 170,
            "elementHandlers": specialElementHandlers
        });

        doc.save("sample-file.pdf");
    });
});

function isNumber(evt) {
    evt = (evt) ? evt : window.event;
    var charCode = (evt.which) ? evt.which : evt.keyCode;
    if (charCode > 31 && (charCode < 45 || charCode > 57)) {
        return false;
    }
    return true;
}
function isNotNumber(evt) {
    evt = (evt) ? evt : window.event;
    var charCode = (evt.which) ? evt.which : evt.keyCode;
    if (charCode > 31 && (charCode < 45 || charCode > 57)) {
        return true;
    }
    return false;
}
function generatePDF() { //Este es el que vamos a usar para Viajes
    var doc = new jsPDF();
    doc.text(20, 20, "Hello World");
    doc.text(20, 30, "ths is client side jS to generate a pdf");



    doc.save("document.pdf");
}

function printPDF() {
    var element = document.getElementById("GridView1");
    html2pdf(element);
}
function demoFromHTML() {
    var pdf = new jsPDF('p', 'pt', 'letter');
    // source can be HTML-formatted string, or a reference
    // to an actual DOM element from which the text will be scraped.
    source = $("#target")[0];

    // we support special element handlers. Register them with jQuery-style 
    // ID selector for either ID or node name. ("#iAmID", "div", "span" etc.)
    // There is no support for any other type of selectors 
    // (class, of compound) at this time.
    specialElementHandlers = {
        // element with id of "bypass" - jQuery style selector
        '#bypassme': function (element, renderer) {
            // true = "handled elsewhere, bypass text extraction"
            return true
        }
    };
    margins = {
        top: 80,
        bottom: 60,
        left: 40,
        width: 522
    };
    // all coords and widths are in jsPDF instance's declared units
    // 'inches' in this case
    pdf.fromHTML(
        source, // HTML string or DOM elem ref.
        margins.left, // x coord
        margins.top, { // y coord
        'width': margins.width, // max width of content on PDF
        'elementHandlers': specialElementHandlers
    },

        function (dispose) {
            // dispose: object with X, Y of the last line add to the PDF 
            //          this allow the insertion of new lines after html
            pdf.save('Test.pdf');
        }, margins);
}
