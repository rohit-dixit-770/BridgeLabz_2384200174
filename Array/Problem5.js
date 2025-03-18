let repeatedDigits = [];

for (let i = 1; i <= 100; i++) {
    
    if (i % 10 === Math.floor(i / 10)) {
        repeatedDigits.push(i);
    }
}

console.log("Repeated digit numbers:", repeatedDigits);
