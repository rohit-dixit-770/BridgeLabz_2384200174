console.log("Enter a number: ");
process.stdin.on('data' , function(input){
    let n = parseInt(input);

    let factors = [];

    if (n <= 1) console.log("Invalid input");
    else {
        for (let i = 2; i * i <= n; i++) {
            while (n % i === 0) {
                factors.push(i);
                n /= i;
            }
        }

        if (n > 1) factors.push(n);      
    }
    
    console.log(factors);
    process.exit();
});


