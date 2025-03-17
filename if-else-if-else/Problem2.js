console.log("Enter a week day number:");

process.stdin.on('data', function (input) {
    let num = parseInt(input);

    if (num === 1) {
        console.log("Sunday");
    } 
    else if (num === 2) {
        console.log("Monday");
    } 
    else if (num === 3) {
        console.log("Tuesday");
    } 
    else if (num === 4) {
        console.log("Wednesday");
    } 
    else if (num === 5) {
        console.log("Thursday");
    } 
    else if (num === 6) {
        console.log("Friday");
    } 
    else if (num === 7) {
        console.log("Saturday");
    } 
    else {
        console.log("Invalid Input");
    }

    process.exit();
});
