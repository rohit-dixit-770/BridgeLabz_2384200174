let low = 1, high = 100, mid;

console.log("Guess a number between 1 and 100");
console.log("Type 'yes' if your number is greater, otherwise type 'no'");

mid = Math.floor((low + high) / 2);  
console.log(`Is your number greater than ${mid}? (yes/no)`);

process.stdin.on('data', function (input) {
    let response = input.toString().trim().toLowerCase();

    if (response === 'yes') {
        low = mid + 1;
    } else if (response === 'no') {
        high = mid;
    } else {
        console.log("Invalid input : Type 'yes' or 'no'");
        return;
    }

    if (low === high) {
        console.log(`\nThe Magic Number is: ${low}`);
        process.exit();
    }

    mid = Math.floor((low + high) / 2);
    console.log(`Is your number greater than ${mid}? (yes/no)`);
});
