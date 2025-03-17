let sum = 0;
for (let i = 0; i < 5; i++) {
    let randomNum = Math.floor(Math.random() * 90) + 10;
    console.log(`Random Number ${i + 1}: ${randomNum}`);
    sum += randomNum;
}
let average = sum / 5;
console.log(`Sum: ${sum}, Average: ${average}`);
