console.log("Enter a number:");

process.stdin.on('data', function (input) {
    let n = parseInt(input);
    if (n <= 1) console.log("Invalid input");
    else {
        console.log(`Prime Factors of ${n}:`);

        for (let i = 2; i * i <= n; i++) {
            while (n % i === 0) {
                console.log(i);
                n /= i;
            }
        }

        if (n > 1) console.log(n);       
    }
    process.exit();
});
