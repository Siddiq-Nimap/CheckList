function AddNumber() {
    var firstnumber = document.getElementById("First").value;
    if (firstnumber == "") {
        alert("First number is required");
        return;
    }
    firstnumber = parseFloat(firstnumber);

    if (isNaN(firstnumber)) {
        alert("Please enter the valid number");
        return;
    }
    var secondnumber = document.getElementById("Second").value;
    if (firstnumber == "") {
        alert("Second number is required");
        return;
    }
    secondnumber = parseFloat(secondnumber);

    if (isNaN(secondnumber)) {
        alert("Please enter the valid number");
        return;
    }

    document.getElementById("Result").value = firstnumber + secondnumber;
}

function showing(){

    var MyArray = new Array(3);

    
    for (var i = 0; i < MyArray.length; i++) {

        MyArray[i] = new Array(3);
    }
    var start = 0
    for (var i = 0; i < 3; i++) {
        for (var j = 0; j < 3; j++) {
            start = start + 1;

            MyArray[i][j] = start;

        }
    }
    for (var i = 0; i < 3; i++) {
        for (var J = 0; J < 3; J++) {
            document.write(MyArray[i][J] + " ");
        }
        document.write("<br/>");

    }

    document.write("<br/>");
    document.write("&emsp;+");
    document.write("<br/>");

    var MyArray1 = new Array(3);


    for (var i = 0; i < MyArray1.length; i++) {

        MyArray1[i] = new Array(3);
    }
    var starts = 10
    for (var i = 0; i < 3; i++) {
        for (var j = 0; j < 3; j++) {
            starts = starts - 1;

            MyArray1[i][j] = starts;
 
        }
    }
    for (var i = 0; i < 3; i++) {
        for (var J = 0; J < 3; J++) {
            document.write(MyArray1[i][J] + " ");
        }
        document.write("<br/>");

    }

    document.write("<br/>");
    document.write("&emsp;+");
    document.write("<br/>");

    var MyArray2 = new Array(3);


    for (var i = 0; i < MyArray1.length; i++) {

        MyArray2[i] = new Array(3);
    }

    for (var i = 0; i < 3; i++) {
        for (var j = 0; j < 3; j++) {

            MyArray2[i][j] = MyArray[i][j] + MyArray1[i][j];

        }
    }
    for (var i = 0; i < 3; i++) {
        for (var J = 0; J < 3; J++) {
            document.write(MyArray2[i][J] + " ");
        }
        document.write("<br/>");

    }
}