console.log("Enter a number:");

process.stdin.on('data', function (input) {
    let n = parseInt(input);
    let factorial = 1;

    for (let i = 2; i <= n; i++) {
        factorial *= i;
    }

    console.log(`Factorial of ${n} is: ${factorial}`);
    process.exit();
});
