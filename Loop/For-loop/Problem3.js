console.log("Enter a number:");

process.stdin.on('data', function (input) {
    let num = parseInt(input);

    if (num < 2) {
        console.log("Not a Prime Number");
        process.exit();
    }

    let isPrime = true;
    for (let i = 2; i * i <= num; i++) {
        if (num % i === 0) {
            isPrime = false;
            break;
        }
    }

    console.log(`${num} is ${isPrime ? "a Prime" : "Not a Prime"} Number`);
    process.exit();
});
