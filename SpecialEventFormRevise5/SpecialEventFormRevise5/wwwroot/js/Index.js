﻿// Index.cshtml


/******************************************************************************************************************************************** Print the HTML page*/
function printPage() {
    document.getElementById("bgVideo").style.display = "none";
    window.print();
    document.getElementById("bgVideo").style.display = "flex";
}

/******************************************************************************************************************************************** Add row to EvenTable*/
function addEventTableRow() {
    // Insert new row into last index of table
    var table = document.getElementById("EventTable");
    var newRow = table.insertRow(document.getElementById("EventTable").getElementsByTagName("tr").length);
    //alert(document.getElementById("EventTable").getElementsByTagName("tr").length);

    // Define and instantiate first column
    var newCell00 = newRow.insertCell(0);
    var cellInput00 = document.createElement('label');
    cellInput00.type = "number";
    cellInput00.innerHTML = document.getElementById("EventTable").getElementsByTagName("tr").length - 1;
    newCell00.appendChild(cellInput00);

    // Define and instantiate second column
    var newCell0 = newRow.insertCell(1);
    var cellInput0 = document.createElement('input');
    cellInput0.type = "date";
    newCell0.appendChild(cellInput0);

    // Define and instantiate third column
    var newCell1 = newRow.insertCell(2);
    var cellInput1 = document.createElement('input');
    cellInput1.type = "text";
    cellInput1.size = 40;
    newCell1.appendChild(cellInput1);

    // Define and instantiate fourth column
    var newCell2 = newRow.insertCell(3);
    var cellInput2 = document.createElement('input');
    cellInput2.type = "number";
    newCell2.appendChild(cellInput2);


    // Insert into column index 4 which is column 5. This is create radiobuttons for served
    var newCell3 = newRow.insertCell(4);

    var cellInput31 = document.createElement('input');
    cellInput31.type = "radio";
    var label31 = document.createElement('label');
    label31.innerHTML = "Yes";
    label31.style.padding = "3px";
    var cellInput32 = document.createElement('input');
    cellInput32.type = "radio";
    var label32 = document.createElement('label');
    label32.innerHTML = "No";
    label32.style.padding = "3px";

    cellInput31.name = "input3";
    cellInput32.name = "input3";

    newCell3.appendChild(cellInput31);
    newCell3.appendChild(label31);
    newCell3.appendChild(cellInput32);
    newCell3.appendChild(label32);



    // Insert into column index 5 which is column 6. This is create radiobuttons for sold
    var newCell4 = newRow.insertCell(5);

    var cellInput41 = document.createElement('input');
    cellInput41.type = "radio";
    var label41 = document.createElement('label');
    label41.innerHTML = "Yes";
    label41.style.padding = "3px";
    var cellInput42 = document.createElement('input');
    cellInput42.type = "radio";
    var label42 = document.createElement('label');
    label42.innerHTML = "No";
    label42.style.padding = "3px";

    cellInput41.name = "input4";
    cellInput42.name = "input4";

    newCell4.appendChild(cellInput41);
    newCell4.appendChild(label41);
    newCell4.appendChild(cellInput42);
    newCell4.appendChild(label42);


    var newHeight = (Math.ceil((Math.sqrt(document.getElementById("EventTable").getElementsByTagName("tr").length))) * 50 + 50).toString() + "px";
    document.getElementById("EventTable").style.height = newHeight;
}

/******************************************************************************************************************************************** Add row to ActivityTable*/
function addActivityTableRow() {
    // Insert new row into last index of table
    var table1 = document.getElementById("ActivityTable");
    var newRow1 = table1.insertRow(document.getElementById("ActivityTable").getElementsByTagName("tr").length);
    //alert(document.getElementById("ActivityTable").getElementsByTagName("tr").length);

    // Define and instantiate first column
    var newCell001 = newRow1.insertCell(0);
    var cellInput001 = document.createElement('label');
    cellInput001.type = "number";
    cellInput001.innerHTML = document.getElementById("ActivityTable").getElementsByTagName("tr").length - 1;
    newCell001.appendChild(cellInput001);

    // Define and instantiate second column
    var newCell01 = newRow1.insertCell(1);
    var cellInput01 = document.createElement('input');
    cellInput01.type = "date";
    newCell01.appendChild(cellInput01);

    // Define and instantiate third column
    var newCell11 = newRow1.insertCell(2);
    var cellInput11 = document.createElement('input');
    cellInput11.type = "text";
    cellInput11.size = 64;
    newCell11.appendChild(cellInput11);

    // Define and instantiate fourth column
    var newCell21 = newRow1.insertCell(3);
    var cellInput21 = document.createElement('input');
    cellInput21.type = "number";
    newCell21.appendChild(cellInput21);


    var newHeight = (Math.ceil((Math.sqrt(document.getElementById("ActivityTable").getElementsByTagName("tr").length))) * 50 + 50).toString() + "px";
    //alert((Math.ceil((document.getElementById("ActivityTable").getElementsByTagName("tr").length / 5)) * 50).toString());
    document.getElementById("ActivityTable").style.height = newHeight;
}

/******************************************************************************************************************************************** Add row to MusicTable*/
function addMusicTableRow() {
    // Insert new row into last index of table
    var table1 = document.getElementById("MusicTable");
    var newRow1 = table1.insertRow(document.getElementById("MusicTable").getElementsByTagName("tr").length);
    //alert(document.getElementById("MusicTable").getElementsByTagName("tr").length);

    // Define and instantiate first column
    var newCell001 = newRow1.insertCell(0);
    var cellInput001 = document.createElement('label');
    cellInput001.type = "number";
    cellInput001.innerHTML = document.getElementById("MusicTable").getElementsByTagName("tr").length - 1;
    newCell001.appendChild(cellInput001);

    // Define and instantiate second column
    var newCell01 = newRow1.insertCell(1);
    var cellInput01 = document.createElement('input');
    cellInput01.type = "text";
    cellInput01.size = 22;
    newCell01.appendChild(cellInput01);

    // Define and instantiate third column
    var newCell11 = newRow1.insertCell(2);
    var cellInput11 = document.createElement('input');
    cellInput11.type = "text";
    cellInput11.size = 42;
    newCell11.appendChild(cellInput11);

    // Define and instantiate fourth column
    var newCell21 = newRow1.insertCell(3);
    var cellInput21 = document.createElement('input');
    cellInput21.type = "number";
    cellInput21.setAttribute("class", "Phone");
    newCell21.appendChild(cellInput21);

    // Define and instantiate fifth column
    var newCell31 = newRow1.insertCell(4);
    var cellInput31 = document.createElement('input');
    cellInput31.type = "text";
    cellInput31.size = 22;
    newCell31.appendChild(cellInput31);


    var newHeight = (Math.ceil((Math.sqrt(document.getElementById("MusicTable").getElementsByTagName("tr").length))) * 50 + 50).toString() + "px";
    // alert((Math.ceil((document.getElementById("MusicTable").getElementsByTagName("tr").length / 5)) * 50).toString());
    document.getElementById("MusicTable").style.height = newHeight;
}

/******************************************************************************************************************************************** Add row to VendorsTable */
function addVendorsTableRow() {
    // Insert new row into last index of table
    var table = document.getElementById("VendorsTable");
    var newRow = table.insertRow(document.getElementById("VendorsTable").getElementsByTagName("tr").length);
    //alert(document.getElementById("VendorsTable").getElementsByTagName("tr").length);

    // Define and instantiate Column 1
    var newCell00 = newRow.insertCell(0);
    var cellInput00 = document.createElement('label');
    cellInput00.type = "number";
    cellInput00.innerHTML = document.getElementById("VendorsTable").getElementsByTagName("tr").length - 1;
    newCell00.appendChild(cellInput00);

    // Define and instantiate Column 2
    var newCell0 = newRow.insertCell(1);
    var cellInput0 = document.createElement('textarea');
    cellInput0.rows = 4;
    newCell0.appendChild(cellInput0);


    // Column 3
    var newCell3 = newRow.insertCell(2);

    //Row 1
    var Row1Div = document.createElement('div');
    Row1Div.setAttribute("class", "row");
    var NameLabel = document.createElement('label');
    NameLabel.innerHTML = " Name ";
    var NameInput = document.createElement('input');
    NameInput.type = "text";
    NameInput.setAttribute("size", "48");
    Row1Div.appendChild(NameLabel);
    Row1Div.appendChild(NameInput);
    newCell3.appendChild(Row1Div);

    //Row 2
    var Row2Div = document.createElement('div');
    Row2Div.setAttribute("class", "row");
    var AddressLabel = document.createElement('label');
    AddressLabel.innerHTML = " Mailing Address ";
    var AddressInput = document.createElement('input');
    AddressInput.setAttribute("size", "45");
    AddressInput.setAttribute("class", "Address");
    Row2Div.appendChild(AddressLabel);
    Row2Div.appendChild(AddressInput);
    newCell3.appendChild(Row2Div);


    //Row 3
    var Row3Div = document.createElement('div');
    Row3Div.setAttribute("class", "row");
    var CityLabel = document.createElement('label');
    CityLabel.innerHTML = " City ";
    var CityInput = document.createElement('input');
    CityInput.type = "text";
    CityInput.setAttribute("class", "City");
    var StateLabel = document.createElement('label');
    StateLabel.innerHTML = " State ";
    var StateInput = document.createElement('input');
    StateInput.type = "text";
    StateInput.setAttribute("class", "State");
    StateInput.setAttribute("maxlength", "2");
    var ZipLabel = document.createElement('label');
    ZipLabel.innerHTML = " Zip ";
    var ZipInput = document.createElement('input');
    ZipInput.type = "number";
    ZipInput.setAttribute("class", "Zip");
    Row3Div.appendChild(CityLabel);
    Row3Div.appendChild(CityInput);
    Row3Div.appendChild(StateLabel);
    Row3Div.appendChild(StateInput);
    Row3Div.appendChild(ZipLabel);
    Row3Div.appendChild(ZipInput);
    newCell3.appendChild(Row3Div);

    //Row 4
    var Row4Div = document.createElement('div');
    Row4Div.setAttribute("class", "row");
    var PhoneLabel = document.createElement('label');
    PhoneLabel.innerHTML = " Phone ";
    var PhoneInput = document.createElement('input');
    PhoneInput.type = "number";
    PhoneInput.size = "10";
    PhoneInput.setAttribute("class", "vendorsPhone");
    Row4Div.appendChild(PhoneLabel);
    Row4Div.appendChild(PhoneInput);
    newCell3.appendChild(Row4Div);


    var newHeight = (Math.ceil((Math.sqrt(document.getElementById("VendorsTable").getElementsByTagName("tr").length))) * 50 + 175).toString() + "px";
    //alert((Math.ceil((document.getElementById("VendorsTable").getElementsByTagName("tr").length / 5)) * 50).toString());
    document.getElementById("VendorsTable").style.height = newHeight;
}

/******************************************************************************************************************************************** Add row to ExhibitorsTable */
function addExhibitorsTableRow() {
    // Insert new row into last index of table
    var table = document.getElementById("ExhibitorsTable");
    var newRow = table.insertRow(document.getElementById("ExhibitorsTable").getElementsByTagName("tr").length);
    //alert(document.getElementById("ExhibitorsTable").getElementsByTagName("tr").length);

    // Define and instantiate Column 1
    var newCell00 = newRow.insertCell(0);
    var cellInput00 = document.createElement('label');
    cellInput00.type = "number";
    cellInput00.innerHTML = document.getElementById("ExhibitorsTable").getElementsByTagName("tr").length - 1;
    newCell00.appendChild(cellInput00);

    // Define and instantiate Column 2
    var newCell0 = newRow.insertCell(1);
    var cellInput0 = document.createElement('textarea');
    cellInput0.rows = 4;
    newCell0.appendChild(cellInput0);


    // Column 3
    var newCell3 = newRow.insertCell(2);

    //Row 1
    var Row1Div = document.createElement('div');
    Row1Div.setAttribute("class", "row");
    var NameLabel = document.createElement('label');
    NameLabel.innerHTML = " Name ";
    var NameInput = document.createElement('input');
    NameInput.type = "text";
    NameInput.setAttribute("size", "48");
    Row1Div.appendChild(NameLabel);
    Row1Div.appendChild(NameInput);
    newCell3.appendChild(Row1Div);

    //Row 2
    var Row2Div = document.createElement('div');
    Row2Div.setAttribute("class", "row");
    var AddressLabel = document.createElement('label');
    AddressLabel.innerHTML = " Mailing Address ";
    var AddressInput = document.createElement('input');
    AddressInput.setAttribute("size", "45");
    AddressInput.setAttribute("class", "Address");
    Row2Div.appendChild(AddressLabel);
    Row2Div.appendChild(AddressInput);
    newCell3.appendChild(Row2Div);


    //Row 3
    var Row3Div = document.createElement('div');
    Row3Div.setAttribute("class", "row");
    var CityLabel = document.createElement('label');
    CityLabel.innerHTML = " City ";
    var CityInput = document.createElement('input');
    CityInput.type = "text";
    CityInput.setAttribute("class", "City");
    var StateLabel = document.createElement('label');
    StateLabel.innerHTML = " State ";
    var StateInput = document.createElement('input');
    StateInput.type = "text";
    StateInput.setAttribute("class", "State");
    StateInput.setAttribute("maxlength", "2");
    var ZipLabel = document.createElement('label');
    ZipLabel.innerHTML = " Zip ";
    var ZipInput = document.createElement('input');
    ZipInput.type = "number";
    ZipInput.setAttribute("class", "Zip");
    Row3Div.appendChild(CityLabel);
    Row3Div.appendChild(CityInput);
    Row3Div.appendChild(StateLabel);
    Row3Div.appendChild(StateInput);
    Row3Div.appendChild(ZipLabel);
    Row3Div.appendChild(ZipInput);
    newCell3.appendChild(Row3Div);

    //Row 4
    var Row4Div = document.createElement('div');
    Row4Div.setAttribute("class", "row");
    var PhoneLabel = document.createElement('label');
    PhoneLabel.innerHTML = " Phone ";
    var PhoneInput = document.createElement('input');
    PhoneInput.type = "number";
    PhoneInput.size = "10";
    PhoneInput.setAttribute("class", "vendorsPhone");
    Row4Div.appendChild(PhoneLabel);
    Row4Div.appendChild(PhoneInput);
    newCell3.appendChild(Row4Div);


    var newHeight = (Math.ceil((Math.sqrt(document.getElementById("ExhibitorsTable").getElementsByTagName("tr").length))) * 50 + 200).toString() + "px";
    //alert((Math.ceil((document.getElementById("ExhibitorsTable").getElementsByTagName("tr").length / 5)) * 50).toString());
    document.getElementById("ExhibitorsTable").style.height = newHeight;
}

/******************************************************************************************************************************************** Add row to SimilarPastEventTable*/
function AddSimilarPastEventTableRow() {
    // Insert new row into last index of table
    var table = document.getElementById("SimilarPastEventTable");
    var newRow = table.insertRow(document.getElementById("SimilarPastEventTable").getElementsByTagName("tr").length);
    //alert(document.getElementById("SimilarPastEventTable").getElementsByTagName("tr").length);

    // Define and instantiate first column
    var newCell00 = newRow.insertCell(0);
    var cellInput00 = document.createElement('label');
    cellInput00.type = "number";
    cellInput00.innerHTML = document.getElementById("SimilarPastEventTable").getElementsByTagName("tr").length - 1;
    newCell00.appendChild(cellInput00);


    // Define and instantiate second column
    var newCell0 = newRow.insertCell(1);
    var cellInput0 = document.createElement('input');
    cellInput0.type = "date";
    newCell0.appendChild(cellInput0);

    // Define and instantiate third column
    var newCell1 = newRow.insertCell(2);
    var cellInput1 = document.createElement('input');
    cellInput1.type = "text";
    cellInput1.size = 20;
    newCell1.appendChild(cellInput1);

    // Define and instantiate fourth column
    var newCell2 = newRow.insertCell(3);
    var cellInput2 = document.createElement('textarea');
    newCell2.appendChild(cellInput2);

    // Define and instantiate fifth column
    var newCell3 = newRow.insertCell(4);
    var cellInput3 = document.createElement('input');
    cellInput3.type = "date";
    newCell3.appendChild(cellInput3);

    // Define and instantiate sixth column
    var newCell4 = newRow.insertCell(5);
    var cellInput4 = document.createElement('input');
    cellInput4.type = "number";
    newCell4.appendChild(cellInput4);

    var newHeight = (Math.ceil((Math.sqrt(document.getElementById("SimilarPastEventTable").getElementsByTagName("tr").length))) * 50 + 100).toString() + "px";
    //alert((Math.ceil((document.getElementById("SimilarPastEventTable").getElementsByTagName("tr").length / 5)) * 50).toString());
    document.getElementById("SimilarPastEventTable").style.height = newHeight;
}

/******************************************************************************************************************************************** Add row to StreetClosureTable */
function addStreetClosureTableRow() {
    // Insert new row into last index of table
    var table1 = document.getElementById("StreetClosureTable");
    var newRow1 = table1.insertRow(document.getElementById("StreetClosureTable").getElementsByTagName("tr").length);
    //alert(document.getElementById("StreetClosureTable").getElementsByTagName("tr").length);

    // Define and instantiate first column
    var newCell001 = newRow1.insertCell(0);
    var cellInput001 = document.createElement('label');
    cellInput001.type = "number";
    cellInput001.innerHTML = document.getElementById("StreetClosureTable").getElementsByTagName("tr").length - 1;
    newCell001.appendChild(cellInput001);

    // Define and instantiate second column
    var newCell01 = newRow1.insertCell(1);
    var cellInput01 = document.createElement('input');
    cellInput01.type = "text";
    cellInput01.size = 84;
    newCell01.appendChild(cellInput01);

    // Define and instantiate third column
    var newCell11 = newRow1.insertCell(2);
    var cellInput11 = document.createElement('input');
    cellInput11.type = "number";
    cellInput11.size = 5;
    newCell11.appendChild(cellInput11);


    var newHeight = (Math.ceil((Math.sqrt(document.getElementById("StreetClosureTable").getElementsByTagName("tr").length))) * 50 + 50).toString() + "px";
    //alert((Math.ceil((document.getElementById("StreetClosureTable").getElementsByTagName("tr").length / 5)) * 50).toString());
    document.getElementById("StreetClosureTable").style.height = newHeight;
}


/************************************************ For collapsible accordion */
var coll = document.getElementsByClassName("collapsible");
var i;

for (i = 0; i < coll.length; i++) {
    coll[i].addEventListener("click", function () {
        this.classList.toggle("active");
        var content = this.nextElementSibling;
        if (content.style.display === "block") {
            content.style.display = "none";
        } else {
            content.style.display = "block";
        }
    });
}

/************************************************ For progress bar */
var userInput = 0;
$(Document).ready(function () {
    var numInput = $("input").length;
    $("input").keyup(function () {

        if (this.validity.valid) {
            userInput++;
            $("#progress").attr("value", Math.ceil(((userInput / numInput) * 100)));
            $("#percentDone").text(Math.ceil(((userInput / numInput) * 100)).toString().concat(" %"));
        }
        //    alert(numInput);
        //   alert(userInput);


    });

});

/************************************************ For pause/play video*/
var vid = document.getElementById("bgVideo");
$("#bgVideo").click(function () {
    if (vid.paused) {
        vid.play();
    }
    else {
        vid.pause();
    }
});

function playVid() {
    vid.play();
}

function pauseVid() {
    vid.pause();
}

function SaveNExit() {
    alert("Your form was saved." + "\n" +
        "Your Login Id is: " + "\n" +
        "Your password is: " + generatePassword());
}

// Password Generator
function generatePassword() {
    var length = 16,
        charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789`~!@#$%^&*()-_=+[{]}\|;:,<.>/?",
        password = "";
    for (var i = 0, n = charset.length; i < length; ++i) {
        password += charset.charAt(Math.floor(Math.random() * n));
    }
    return password;
}

// All the If Yes Option functions are down here
///////////////////////////////////////////////////////////////////////

// Enable/Disable ApplicantInformation NameInsured Other text input
function nameInsuredOtherFunction() {
    var checkBox = document.getElementById("NameInsuredOtherCheckBox");
    var text = document.getElementById("NameInsuredOtherInputText");
    if (checkBox.checked == true) {
        //text.style.display = "block";
        //alert("Now it is unchecked");
        document.getElementById("NameInsuredOtherInputText").disabled = false;
        document.getElementById("NameInsuredOtherInputText").style.visibility = "visible";
        document.getElementById("NameInsuredOtherInputText").style.display = "block";

    } else {
        //text.style.display = "none";
        //alert("Now it is checked");
        document.getElementById("NameInsuredOtherInputText").disabled = true;
        document.getElementById("NameInsuredOtherInputText").value = "";
        document.getElementById("NameInsuredOtherInputText").style.visibility = "hidden";
        document.getElementById("NameInsuredOtherInputText").style.display = "none";


    }
}

// Enable/Disable EventInformation AdmissionCharge
function admissionCharge() {
    admissionOptions = document.getElementsByName("AdmissionCharge");
    sellTicketOption = document.getElementsByName("SellTicket");
    howTicketsAreSold = document.getElementsByName("HowToSellTicket");

    if (admissionOptions[0].checked) {
        //alert("Yes is selected");
        document.getElementById("admissionChargeSection").style.visibility = "visible";
        document.getElementById("admissionChargeSection").style.display = "block";

        document.getElementById("sellTicketsSection").style.visibility = "hidden";
        document.getElementById("sellTicketsSection").style.display = "none";

        document.getElementById("admissionChargeCostInput").value = "";
        sellTicketOption[0].checked = false;
        sellTicketOption[1].checked = false;
        document.getElementById("numberofTicketSales").value = "";
        document.getElementById("totalReceipts").value = "";
        document.getElementById("pricePerTicket").value = "";
        howTicketsAreSold[0].checked = false;
        howTicketsAreSold[1].checked = false;
        howTicketsAreSold[2].checked = false;
        document.getElementById("whoSellsTickets").value = "";
    }
    if (admissionOptions[1].checked) {
        //alert("No is selected");
        document.getElementById("admissionChargeSection").style.visibility = "hidden";
        document.getElementById("admissionChargeSection").style.display = "none";

        document.getElementById("sellTicketsSection").style.visibility = "hidden";
        document.getElementById("sellTicketsSection").style.display = "none";

        document.getElementById("admissionChargeCostInput").value = "";
        sellTicketOption[0].checked = false;
        sellTicketOption[1].checked = false;
        document.getElementById("numberofTicketSales").value = "";
        document.getElementById("totalReceipts").value = "";
        document.getElementById("pricePerTicket").value = "";
        howTicketsAreSold[0].checked = false;
        howTicketsAreSold[1].checked = false;
        howTicketsAreSold[2].checked = false;
        document.getElementById("whoSellsTickets").value = "";
    }
}

// Enable/Disable EventInformation TicketSelling
function sellTickets() {
    sellingTickets = document.getElementsByName("SellTicket");
    howTicketsAreSold = document.getElementsByName("HowToSellTicket");

    if (sellingTickets[0].checked) {
        document.getElementById("sellTicketsSection").style.visibility = "visible";
        document.getElementById("sellTicketsSection").style.display = "block";

        document.getElementById("numberofTicketSales").value = "";
        document.getElementById("totalReceipts").value = "";
        document.getElementById("pricePerTicket").value = "";
        howTicketsAreSold[0].checked = false;
        howTicketsAreSold[1].checked = false;
        howTicketsAreSold[2].checked = false;
        document.getElementById("whoSellsTickets").value = "";
    }
    if (sellingTickets[1].checked) {
        document.getElementById("sellTicketsSection").style.visibility = "hidden";
        document.getElementById("sellTicketsSection").style.display = "none";

        document.getElementById("numberofTicketSales").value = "";
        document.getElementById("totalReceipts").value = "";
        document.getElementById("pricePerTicket").value = "";
        howTicketsAreSold[0].checked = false;
        howTicketsAreSold[1].checked = false;
        howTicketsAreSold[2].checked = false;
        document.getElementById("whoSellsTickets").value = "";
    }
}

// Enable/Disable EventInformation FirstAide
function firstAide() {
    firstAideSelection = document.getElementsByName("FirstAid");

    if (firstAideSelection[0].checked) {
        document.getElementById("firstAideSection").style.visibility = "visible";
        document.getElementById("firstAideSection").style.display = "block";

        document.getElementById("firstAideCompany").value = "";
        document.getElementById("receivedFirstAideCertificates").value = "";

    }
    if (firstAideSelection[1].checked) {
        document.getElementById("firstAideSection").style.visibility = "hidden";
        document.getElementById("firstAideSection").style.display = "none";

        document.getElementById("firstAideCompany").value = "";
        document.getElementById("receivedFirstAideCertificates").value = "";
    }
}

// Enable/Disable EventInformation EventAdvertised
function eventAdvertised() {
    eventAdvertisedSelection = document.getElementsByName("EventAdvertise");

    eventWebsite = document.getElementsByName("EventWebsite");
    eventTelevised = document.getElementsByName("EvenTelevised");
    eventRadio = document.getElementsByName("EventRadio");
    eventNewsPaper = document.getElementsByName("EventNewsPaper");
    eventBrochure = document.getElementsByName("EventBrochure");
    eventHandOut = document.getElementsByName("EventHandOut");
    eventBillBoard = document.getElementsByName("EventBillBoard");
    eventPoster = document.getElementsByName("EventPoster");
    eventOther = document.getElementsByName("EventOther");

    if (eventAdvertisedSelection[0].checked) {
        document.getElementById("eventAdvertiseSection").style.visibility = "visible";
        document.getElementById("eventAdvertiseSection").style.display = "block";

        document.getElementById("advertiseWebsite").value = "";

        eventWebsite[0].checked = false;
        eventWebsite[1].checked = false;
        eventTelevised[0].checked = false;
        eventTelevised[1].checked = false;
        eventRadio[0].checked = false;
        eventRadio[1].checked = false;
        eventNewsPaper[0].checked = false;
        eventNewsPaper[1].checked = false;
        eventBrochure[0].checked = false;
        eventBrochure[1].checked = false;
        eventHandOut[0].checked = false;
        eventHandOut[1].checked = false;
        eventBillBoard[0].checked = false;
        eventBillBoard[1].checked = false;
        eventPoster[0].checked = false;
        eventPoster[1].checked = false;
        eventOther[0].checked = false;
        eventOther[1].checked = false;

    }
    if (eventAdvertisedSelection[1].checked) {
        document.getElementById("eventAdvertiseSection").style.visibility = "hidden";
        document.getElementById("eventAdvertiseSection").style.display = "none";

        document.getElementById("advertiseWebsite").value = "";

        eventWebsite[0].checked = false;
        eventWebsite[1].checked = false;
        eventTelevised[0].checked = false;
        eventTelevised[1].checked = false;
        eventRadio[0].checked = false;
        eventRadio[1].checked = false;
        eventNewsPaper[0].checked = false;
        eventNewsPaper[1].checked = false;
        eventBrochure[0].checked = false;
        eventBrochure[1].checked = false;
        eventHandOut[0].checked = false;
        eventHandOut[1].checked = false;
        eventBillBoard[0].checked = false;
        eventBillBoard[1].checked = false;
        eventPoster[0].checked = false;
        eventPoster[1].checked = false;
        eventOther[0].checked = false;
        eventOther[1].checked = false;
    }
}

// Enable
function eventMainWebsite() {
    eventWebsiteName = document.getElementsByName("EventWebsite");

    if (eventWebsiteName[0].checked) {
        document.getElementById("advertiseWebsite").style.visibility = "visible";
        document.getElementById("advertiseWebsite").style.display = "block";
        document.getElementById("advertiseWebsite").value = "";
    }
    if (eventWebsiteName[1].checked) {
        document.getElementById("advertiseWebsite").style.visibility = "hidden";
        document.getElementById("advertiseWebsite").style.display = "none";
        document.getElementById("advertiseWebsite").value = "";
    }

}

// Enable/Disable EventInformation AlcoholIsServed
function alcoholServed(){
    alcoholServedSelection = document.getElementsByName("AlcoholServe");

    alcoholIsBeingSold = document.getElementsByName("AlcoholIsSold");
    alcoholFee = document.getElementsByName("AlcoholFee");
    eventFee = document.getElementsByName("EventFee");
    eventDonation = document.getElementsByName("EventDonation");

    alcoholType = document.getElementsByName("AlcoholType");
    alcoholVending = document.getElementsByName("AlcoholVending");
    alcoholVendingInsurance = document.getElementsByName("AlcoholVendingInsurance");
    liqourLicensing = document.getElementsByName("LiquorLicense");

    liquorDrinkArea = document.getElementsByName("LiquorDrinkArea");
    liquorIdentification = document.getElementsByName("LiquorIdentification");
    drinkingAge = document.getElementsByName("DrinkingAge");
    liquorServingLimit = document.getElementsByName("LiquorServingLimit");
    liquorStaffMonitor = document.getElementsByName("LiquorStaffMonitor");
    liquorBarClose = document.getElementsByName("LiquorBarClose");


    if (alcoholServedSelection[0].checked) {
        document.getElementById("alcoholServeSection").style.visibility = "visible";
        document.getElementById("alcoholServeSection").style.display = "block";

        alcoholIsBeingSold[0].checked = false;
        alcoholIsBeingSold[1].checked = false;
        alcoholFee[0].checked = false;
        alcoholFee[1].checked = false;
        eventFee[0].checked = false;
        eventFee[1].checked = false;
        eventDonation[0].checked = false;
        eventDonation[1].checked = false;
        document.getElementById("alcoholSold").style.visibility = "hidden";
        document.getElementById("alcoholSold").style.display = "block";

        document.getElementById("estimatedAlcoholSales").style.visibility = "visible";
        document.getElementById("estimatedAlcoholSales").style.display = "block";

        document.getElementById("alcoholEstimatedSales").value = ""


        alcoholType[0].checked = false;
        alcoholType[1].checked = false;
        alcoholType[2].checked = false;
        alcoholVending[0].checked = false;
        alcoholVending[1].checked = false;
        document.getElementById("alcoholEstimatedSales").value = "";
        document.getElementById("howManyDifferentAlcohol").value = "";
        liqourLicensing[0].checked = false;
        liqourLicensing[1].checked = false;

        liquorDrinkArea[0].checked = false;
        liquorDrinkArea[1].checked = false;
        liquorIdentification[0].checked = false;
        liquorIdentification[1].checked = false;
        drinkingAge[0].checked = false;
        drinkingAge[1].checked = false;
        liquorServingLimit[0].checked = false;
        liquorServingLimit[1].checked = false;
        liquorStaffMonitor[0].checked = false;
        liquorStaffMonitor[1].checked = false;
        liquorBarClose[0].checked = false;
        liquorBarClose[1].checked = false;
    }

    if (alcoholServedSelection[1].checked) {
        document.getElementById("alcoholServeSection").style.visibility = "hidden";
        document.getElementById("alcoholServeSection").style.display = "none";

        alcoholIsBeingSold[0].checked = false;
        alcoholIsBeingSold[1].checked = false;
        alcoholFee[0].checked = false;
        alcoholFee[1].checked = false;
        eventFee[0].checked = false;
        eventFee[1].checked = false;
        eventDonation[0].checked = false;
        eventDonation[1].checked = false;
        document.getElementById("alcoholSold").style.visibility = "hidden";
        document.getElementById("alcoholSold").style.display = "none";

        document.getElementById("estimatedAlcoholSales").style.visibility = "hidden";
        document.getElementById("estimatedAlcoholSales").style.display = "none";

        document.getElementById("alcoholEstimatedSales").value = ""


        alcoholType[0].checked = false;
        alcoholType[1].checked = false;
        alcoholType[2].checked = false;
        alcoholVending[0].checked = false;
        alcoholVending[1].checked = false;
        document.getElementById("alcoholEstimatedSales").value = "";
        document.getElementById("howManyDifferentAlcohol").value = "";
        liqourLicensing[0].checked = false;
        liqourLicensing[1].checked = false;

        liquorDrinkArea[0].checked = false;
        liquorDrinkArea[1].checked = false;
        liquorIdentification[0].checked = false;
        liquorIdentification[1].checked = false;
        drinkingAge[0].checked = false;
        drinkingAge[1].checked = false;
        liquorServingLimit[0].checked = false;
        liquorServingLimit[1].checked = false;
        liquorStaffMonitor[0].checked = false;
        liquorStaffMonitor[1].checked = false;
        liquorBarClose[0].checked = false;
        liquorBarClose[1].checked = false;
    }

}

// Enable/Disable EventInformation AlcoholIsSold
function alcoholSold() {
    alcoholSoldSelection = document.getElementsByName("AlcoholIsSold");

    alcoholFee = document.getElementsByName("AlcoholFee");
    eventFee = document.getElementsByName("EventFee");
    eventDonation = document.getElementsByName("EventDonation");


    if (alcoholSoldSelection[0].checked) {
        alcoholFee[0].checked = false;
        alcoholFee[1].checked = false;
        eventFee[0].checked = false;
        eventFee[1].checked = false;
        eventDonation[0].checked = false;
        eventDonation[1].checked = false;
        document.getElementById("alcoholSold").style.visibility = "visible";
        document.getElementById("alcoholSold").style.display = "block";

        document.getElementById("estimatedAlcoholSales").style.visibility = "visible";
        document.getElementById("estimatedAlcoholSales").style.display = "block";

        document.getElementById("alcoholEstimatedSales").value = "";
    }
    if (alcoholSoldSelection[1].checked) {
        alcoholFee[0].checked = false;
        alcoholFee[1].checked = false;
        eventFee[0].checked = false;
        eventFee[1].checked = false;
        eventDonation[0].checked = false;
        eventDonation[1].checked = false;
        document.getElementById("alcoholSold").style.visibility = "hidden";
        document.getElementById("alcoholSold").style.display = "none";

        document.getElementById("estimatedAlcoholSales").style.visibility = "hidden";
        document.getElementById("estimatedAlcoholSales").style.display = "none";

        document.getElementById("alcoholEstimatedSales").value = "";
    }
} 

// Enable/Disable EventInformation VendorLiquorLiability
function vendorServeOrSellLiquor() {
    vendorSellAlcohol = document.getElementsByName("AlcoholVending");
    vendorLiability = document.getElementsByName("AlcoholVendingInsurance");

    if (vendorSellAlcohol[0].checked) {
        document.getElementById("vendorLiquorSellingLiability").style.visibility = "visible";
        document.getElementById("vendorLiquorSellingLiability").style.display = "block";

        vendorLiability[0].checked = false;
        vendorLiability[1].checked = false;
    }
    if (vendorSellAlcohol[1].checked) {
        document.getElementById("vendorLiquorSellingLiability").style.visibility = "hidden";
        document.getElementById("vendorLiquorSellingLiability").style.display = "none";

        vendorLiability[0].checked = false;
        vendorLiability[1].checked = false;
    }

}

// Enable/Disable EventInformation AthleticOrRecreationalActivities
function athleticOrRecreationalActivity() {
    athleticRecreationalActivity = document.getElementsByName("AthleticRecreationalActivity");
    activityTable = document.getElementById("ActivityTable");


    if (athleticRecreationalActivity[0].checked) {
        document.getElementById("athleticRecreationActivitySection").style.visibility = "visible";
        document.getElementById("athleticRecreationActivitySection").style.display = "block";

        for (var i = activityTable.rows.length - 1; i > 0; i--) {
            activityTable.deleteRow(i);
        }
        addActivityTableRow();

        document.getElementById("procedureExplaination").value = "";
        document.getElementById("liabilityReleaseFile").value = "";
    }
    if (athleticRecreationalActivity[1].checked) {
        document.getElementById("athleticRecreationActivitySection").style.visibility = "hidden";
        document.getElementById("athleticRecreationActivitySection").style.display = "none";

        for (var i = activityTable.rows.length - 1; i > 0; i--) {
            activityTable.deleteRow(i);
        }
        addActivityTableRow(); 

        document.getElementById("procedureExplaination").value = "";
        document.getElementById("liabilityReleaseFile").value = "";
    }
}

// Enable/Disable EventInformation HavingMusic
function haveMusic() {
    hasMusic = document.getElementsByName("HaveMusic");
    typeOfMusic = document.getElementsByName("TypeOfMusic");
    amplifiedMusic = document.getElementsByName("AmplifiedMusic");

    musicTable = document.getElementById("MusicTable");

    musicType = document.getElementsByName("MusicTypeCheckBox");
    ownElectricity = document.getElementsByName("OwnElectricity");
    otherEntertainment = document.getElementsByName("OtherEntertainment");

    if (hasMusic[0].checked) {
        document.getElementById("musicSection").style.visibility = "visible";
        document.getElementById("musicSection").style.display = "block";

        typeOfMusic[0].checked = false;
        typeOfMusic[1].checked = false;
        typeOfMusic[2].checked = false;
        amplifiedMusic[0].checked = false;
        amplifiedMusic[1].checked = false;
        document.getElementById("howManyBands").value = "";

        for (var i = musicTable.rows.length - 1; i > 0; i--) {
            musicTable.deleteRow(i);
        }
        addMusicTableRow();

        for (int = 0; i < musicType.length; i++) {
            musicType[i].checked = false;
        }

        document.getElementById("musicOtherType").value = "";

        ownElectricity[0].checked = false;
        ownElectricity[1].checked = false;
        document.getElementById("electricityArrangement").value = "";
        otherEntertainment[0].checked = false;
        otherEntertainment[0].checked = false;
        document.getElementById("otherEntertainmentDescription").value = "";

    }

    if (hasMusic[1].checked) {
        document.getElementById("musicSection").style.visibility = "hidden";
        document.getElementById("musicSection").style.display = "none";

        typeOfMusic[0].checked = false;
        typeOfMusic[1].checked = false;
        typeOfMusic[2].checked = false;
        amplifiedMusic[0].checked = false;
        amplifiedMusic[1].checked = false;
        document.getElementById("howManyBands").value = "";

        for (var i = musicTable.rows.length - 1; i > 0; i--) {
            musicTable.deleteRow(i);
        }
        addMusicTableRow();

        for (int = 0; i < musicType.length; i++) {
            musicType[i].checked = false;
        }

        document.getElementById("musicOtherType").value = "";

        ownElectricity[0].checked = false;
        ownElectricity[1].checked = false;
        document.getElementById("electricityArrangement").value = "";
        otherEntertainment[0].checked = false;
        otherEntertainment[0].checked = false;
        document.getElementById("otherEntertainmentDescription").value = "";
    }
}

// Enable/Disable EventInformation OwnElectricity
function haveOwnElectricity() {
    ownElectricitySelection = document.getElementsByName("OwnElectricity");

    if (ownElectricitySelection[0].checked) {
        document.getElementById("arrangementsMade").style.visibility = "hidden";
        document.getElementById("otherTypeOfEntertainment").style.display = "block";

        document.getElementById("electricityArrangement").style.visibility = "hidden";
        document.getElementById("otherTypeOfEntertainment").style.display = "block";

        document.getElementById("electricityArrangement").value = "";
    }

    if (ownElectricitySelection[1].checked) {
        document.getElementById("arrangementsMade").style.visibility = "visible";
        document.getElementById("arrangementsMade").style.display = "none";

        document.getElementById("electricityArrangement").style.visibility = "visible";
        document.getElementById("electricityArrangement").style.display = "none";

        document.getElementById("electricityArrangement").value = "";
    }

}

// Enable/Disable EventInformation OtherEntertainment
function typeOfOtherEntertainment() {
    otherEntertainmentSelection = document.getElementsByName("OtherEntertainment");

    if (otherEntertainmentSelection[0].checked) {
        document.getElementById("otherTypeOfEntertainment").style.visibility = "visible";
        document.getElementById("otherTypeOfEntertainment").style.display = "block";

        document.getElementById("otherEntertainmentDescription").style.visibility = "visible";
        document.getElementById("otherEntertainmentDescription").style.display = "block";

        document.getElementById("otherEntertainmentDescription").value = "";
    }

    if (otherEntertainmentSelection[1].checked) {
        document.getElementById("otherTypeOfEntertainment").style.visibility = "hidden";
        document.getElementById("otherTypeOfEntertainment").style.display = "none";

        document.getElementById("otherEntertainmentDescription").style.visibility = "hidden";
        document.getElementById("otherEntertainmentDescription").style.display = "none";

        document.getElementById("otherEntertainmentDescription").value = "";
    }
}

// Enable/Disable EventInformation OtherActivities 
function activitiesAndOthers() {
    activitiesStuffSelection = document.getElementsByName("ActivityStuff");

    activity1 = document.getElementsByName("ClimbWall");
    activity2 = document.getElementsByName("SkateBoard");
    activity3 = document.getElementsByName("RollerAct");
    activity4 = document.getElementsByName("CycleAct");
    activity5 = document.getElementsByName("WaterAct");
    activity6 = document.getElementsByName("GunAct");
    activity7 = document.getElementsByName("FireAct");
    activity8 = document.getElementsByName("ArmoryAct");
    activity9 = document.getElementsByName("ChemicalAct");
    activity9 = document.getElementsByName("MedicalAct");
    activity10 = document.getElementsByName("DemolitionAct");
    activity11 = document.getElementsByName("ScaffoldingfAct");



    if (activitiesStuffSelection[0].checked) {
        document.getElementById("activitiesSection").style.visibility = "visible";
        document.getElementById("activitiesSection").style.display = "block";

        document.getElementById("followingActivitesFile").value = "";
        document.getElementById("hiredCompany").value = "";
        activity1[0].checked = false;
        activity1[1].checked = false;
        activity2[0].checked = false;
        activity2[1].checked = false;
        activity3[0].checked = false;
        activity3[1].checked = false;
        activity4[0].checked = false;
        activity4[1].checked = false;
        activity5[0].checked = false;
        activity5[1].checked = false;
        activity6[0].checked = false;
        activity6[1].checked = false;
        activity7[0].checked = false;
        activity7[1].checked = false;
        activity8[0].checked = false;
        activity8[1].checked = false;
        activity9[0].checked = false;
        activity9[1].checked = false;
        activity10[0].checked = false;
        activity10[1].checked = false;
        activity11[0].checked = false;
        activity11[1].checked = false;
    }

    if (activitiesStuffSelection[1].checked) {
        document.getElementById("activitiesSection").style.visibility = "hidden";
        document.getElementById("activitiesSection").style.display = "none";

        document.getElementById("followingActivitesFile").value = "";
        document.getElementById("hiredCompany").value = "";
        activity1[0].checked = false;
        activity1[1].checked = false;
        activity2[0].checked = false;
        activity2[1].checked = false;
        activity3[0].checked = false;
        activity3[1].checked = false;
        activity4[0].checked = false;
        activity4[1].checked = false;
        activity5[0].checked = false;
        activity5[1].checked = false;
        activity6[0].checked = false;
        activity6[1].checked = false;
        activity7[0].checked = false;
        activity7[1].checked = false;
        activity8[0].checked = false;
        activity8[1].checked = false;
        activity9[0].checked = false;
        activity9[1].checked = false;
        activity10[0].checked = false;
        activity10[1].checked = false;
        activity11[0].checked = false;
        activity11[1].checked = false;    }
}

// Enable/Disable EventLoaction PastEvents
function pastEvents() {
    pastEventHeld = document.getElementsByName("HeldBefore");

    similarPastEventTable = document.getElementById("SimilarPastEventTable");


    if (pastEventHeld[0].checked) {
        document.getElementById("previousSimilarEvents").style.visibility = "visible";
        document.getElementById("previousSimilarEvents").style.display = "block";


        for (var i = similarPastEventTable.rows.length - 1; i > 0; i--) {
            similarPastEventTable.deleteRow(i);
        }
        AddSimilarPastEventTableRow(); 
    }

    if (pastEventHeld[1].checked) {
        document.getElementById("previousSimilarEvents").style.visibility = "hidden";
        document.getElementById("previousSimilarEvents").style.display = "none";

        for (var i = similarPastEventTable.rows.length - 1; i > 0; i--) {
            similarPastEventTable.deleteRow(i);
        }
        AddSimilarPastEventTableRow(); 
    }
}

// Enable/Disable EventLoaction EmergencyEvacuationPlan
function emergencyEvacuationPlan() {
    evacPlan = document.getElementsByName("EvacuationPlan");

    similarPastEventTable = document.getElementById("SimilarPastEventTable");


    if (evacPlan[0].checked) {
        document.getElementById("emergencyEvacuationExplaination").style.visibility = "visible";
        document.getElementById("emergencyEvacuationExplaination").style.display = "block";

        document.getElementById("howAttendeesNotifiedEvacuation").value = "";
    }

    if (evacPlan[1].checked) {
        document.getElementById("emergencyEvacuationExplaination").style.visibility = "hidden";
        document.getElementById("emergencyEvacuationExplaination").style.display = "none";

        document.getElementById("howAttendeesNotifiedEvacuation").value = "";

    }
}

// Enable/Disable EventLoaction MedicalPresentAtEvent
function medicalServicePresent() {
    medicalPresence = document.getElementsByName("MedicalPresence");
    abulancePresence = document.getElementsByName("AmbulanceOnSite");

    if (medicalPresence[0].checked) {
        document.getElementById("medicalPresent").style.visibility = "visible";
        document.getElementById("medicalPresent").style.display = "block";
        document.getElementById("numberOfDoctors").value = "";
        document.getElementById("numberOfParamedics").value = "";
        document.getElementById("numberOfNurses").value = "";
        document.getElementById("numberOfEMT/EMS").value = "";
        document.getElementById("numberOfOther").value = "";
        abulancePresence[0].checked = false;
        abulancePresence[1].checked = false;

    }

    if (medicalPresence[1].checked) {
        document.getElementById("medicalPresent").style.visibility = "hidden";
        document.getElementById("medicalPresent").style.display = "none";
        document.getElementById("numberOfDoctors").value = "";
        document.getElementById("numberOfParamedics").value = "";
        document.getElementById("numberOfNurses").value = "";
        document.getElementById("numberOfEMT/EMS").value = "";
        document.getElementById("numberOfOther").value = "";
        abulancePresence[0].checked = false;
        abulancePresence[1].checked = false;

    }
}

// Enable/Disable EventLoaction StreetClosure
function streetClosureNeed() {
    streetClosing = document.getElementsByName("StreetClosure");
    trafficMitigating = document.getElementsByName("TrafficMitigation");

    streetClosureTable = document.getElementById("StreetClosureTable");

    if (streetClosing[0].checked) {
        document.getElementById("streetClosures").style.visibility = "visible";
        document.getElementById("streetClosures").style.display = "block";

        for (var i = streetClosureTable.rows.length - 1; i > 0; i--) {
            streetClosureTable.deleteRow(i);
        }
        addStreetClosureTableRow(); 

        trafficMitigating[0].checked = false;
        trafficMitigating[1].checked = false;

        document.getElementById("trafficMitigationDescription").value = "";
        document.getElementById("30DaysPriorInsure").value = "";
    }

    if (streetClosing[1].checked) {
        document.getElementById("streetClosures").style.visibility = "hidden";
        document.getElementById("streetClosures").style.display = "none";

        for (var i = streetClosureTable.rows.length - 1; i > 0; i--) {
            streetClosureTable.deleteRow(i);
        }
        addStreetClosureTableRow();

        trafficMitigating[0].checked = false;
        trafficMitigating[1].checked = false;

        document.getElementById("trafficMitigationDescription").value = "";
        document.getElementById("30DaysPriorInsure").value = "";
    }
}

// Enable/Disable EventLoaction TrafficMitigation
function trafficMitigations() {
    trafficMitigating = document.getElementsByName("TrafficMitigation");

    if (trafficMitigating[0].checked) {
        document.getElementById("trafficMitigationOptions").style.visibility = "visible";
        document.getElementById("trafficMitigationOptions").style.display = "block";
        document.getElementById("trafficMitigationDescription").value = "";
    }
    if (trafficMitigating[1].checked) {
        document.getElementById("trafficMitigationOptions").style.visibility = "hidden";
        document.getElementById("trafficMitigationOptions").style.display = "none";
        document.getElementById("trafficMitigationDescription").value = "";
    }
}
