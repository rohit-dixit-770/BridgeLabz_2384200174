console.log("Enter a single digit number:");

process.stdin.on('data', function (input) {
    let num = parseInt(input);

    if (num === 0) {
        console.log("Zero");
    } 
    else if (num === 1) {
        console.log("One");
    } 
    else if (num === 2) {
        console.log("Two");
    } 
    else if (num === 3) {
        console.log("Three");
    } 
    else if (num === 4) {
        console.log("Four");
    } 
    else if (num === 5) {
        console.log("Five");
    } 
    else if (num === 6) {
        console.log("Six");
    } 
    else if (num === 7) {
        console.log("Seven");
    } 
    else if (num === 8) {
        console.log("Eight");
    } 
    else if (num === 9) {
        console.log("Nine");
    } 
    else {
        console.log("Invalid Input");
    }

    process.exit();
});



