console.log("Enter start and end number range:");

process.stdin.on('data', function (input) {
    let [start, end] = input.toString().split(" ").map(Number);


    for (let num = start; num <= end; num++) {
        if (num < 2) continue;

        let isPrime = true;
        for (let i = 2; i * i <= num; i++) {
            if (num % i === 0) {
                isPrime = false;
                break;
            }
        }

        if (isPrime) console.log(num);
    }

    process.exit();
});
