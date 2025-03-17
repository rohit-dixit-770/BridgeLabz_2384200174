console.log("Enter a number as 1, 10, 100, 1000:");

process.stdin.on('data', function (input) {
    let num = parseInt(input);

    switch (num) {
        case 1:
            console.log("Unit");
            break;
        case 10:
            console.log("Ten");
            break;
        case 100:
            console.log("Hundred");
            break;
        case 1000:
            console.log("Thousand");
            break;
        case 10000:
            console.log("Ten Thousand");
            break;
        case 100000:
            console.log("Lakh");
            break;
        case 1000000:
            console.log("Ten Lakh");
            break;
        case 10000000:
            console.log("Crore");
            break;
        default:
            console.log("Invalid Input: Number must be in the form of (10^x)");
    }

    process.exit();
});
