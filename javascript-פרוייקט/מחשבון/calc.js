let num1 = null;
let num2 = null;
let opp = '';
let currentNum = '';
function addNum() {
    let n = event.srcElement.innerHTML;
    if (currentNum.length == 1 && currentNum.charAt(0) == "0") {
        currentNum = n;
    }
    else {
        currentNum += n;
    }
    print();
}
function addpoint() {
    if (currentNum.length == 0) {
        currentNum = "0."
        print();
    }
    else {
        if (currentNum.indexOf(".") == -1) {
            currentNum += ".";
            print();
        }
    }
}

function print() {
    document.getElementById("screen").innerHTML = currentNum;
}
function chageSiman() {
    if (currentNum.indexOf("-") == -1) {
        currentNum = "-" + currentNum;
    }
    else {
        currentNum = currentNum.replace('-', '');
    } print();
}
function ce() {
    currentNum = "0";
    print();

}
function c() {
    num1 = 0;
    num2 = 0;
    currentNum = "0";
    opp = "";
    print();
}
function x() {
    currentNum = currentNum.slice(0, currentNum.length - 1);
    if (currentNum.length == 0) {
        currentNum = "0";

    }
    print();
}
function opps() {
    if (document.getElementById("screen").innerHTML != currentNum) {
        document.getElementById("screen").innerHTML = currentNum + event.srcElement.innerHTML;
    }
    if (currentNum.length == 0) {
        currentNum = "0";

    }
    print();
    if (num1 == null) {
        num1 = currentNum;
        currentNum = "0";
    }
    else {
        num1 = callac(num1, opp, currentNum);
    }
    currentNum = '';
    opp = event.srcElement.innerHTML;
    document.getElementById("screen").innerHTML = num1;
    document.getElementById("screen").innerHTML += opp;

}
function callac(num1, opp, num2) {
    num1 = parseFloat(num1);
    num2 = parseFloat(num2);
    let ans;
    switch (opp) {
        case "+": ans = num1 + num2; break;
        case "-": ans = num1 - num2; break;
        case "*": ans = num1 * num2; break;
        case "/": ans = num1 / num2; break;
    }
    return ans;

}
function finalAns() {
    // let fans= callac(num1.opp,currentNum)
    document.getElementById("screen").innerHTML = callac(num1, opp, currentNum);


}