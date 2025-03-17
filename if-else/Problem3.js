console.log("Enter a year: ");

process.stdin.on('data', function (input) {
    let year = parseInt(input);

    if ((year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0)) {
        console.log("Leap Year");
    } else {
        console.log("Not a Leap Year");
    }

    process.exit();
});
