console.log("Enter a number to find the nth harmonic number:");

process.stdin.on('data', function (input) {
    let n = parseInt(input);
    let harmonic = 0;

    for (let i = 1; i <= n; i++) {
        harmonic += 1 / i;
    }

    console.log(`The ${n}th Harmonic Number is: ${harmonic.toFixed(6)}`);
    process.exit();
});
