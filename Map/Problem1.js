let diceResults = { 1: 0, 2: 0, 3: 0, 4: 0, 5: 0, 6: 0 };

while (true) {
    let roll = Math.floor(Math.random() * 6) + 1;
    diceResults[roll]++;

    if (diceResults[roll] === 10) {
        break;
    }
}

console.log("Final Dice Counts:", diceResults);

let maxNumber, minNumber;
let maxRolled = -Infinity, minRolled = Infinity;

for (let [num, count] of Object.entries(diceResults)) {
    if (count > maxRolled) {
        maxRolled = count;
        maxNumber = num;
    }
    if (count < minRolled) {
        minRolled = count;
        minNumber = num;
    }
}

console.log(`Most frequently rolled: ${maxNumber} - (${maxRolled} times)`);
console.log(`Least frequently rolled: ${minNumber} - (${minRolled} times)`);
