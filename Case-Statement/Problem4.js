console.log(
    "Choose conversion:\n" +
    "1. Feet to Inch\n" +
    "2. Feet to Meter\n" +
    "3. Inch to Feet\n" +
    "4. Meter to Feet\n"
);

console.log("Enter your choice (1-4):");

process.stdin.once('data', function (input) {
    let choice = parseInt(input);

    if (choice < 1 || choice > 4) {
        console.log("\nInvalid choice: enter a number between 1 and 4");
        process.exit();
    }

    console.log("\nEnter the value to convert:");

    process.stdin.once('data', function (inputValue) {
        let value = parseFloat(inputValue);
        let result;
        let output;

        switch (choice) {
            case 1:
                result = value * 12;
                output = `${value} Feet = ${result} Inches`;
                break;
            case 2:
                result = value * 0.3048;
                output = `${value} Feet = ${result} Meters`;
                break;
            case 3:
                result = value / 12;
                output = `${value} Inches = ${result} Feet`;
                break;
            case 4:
                result = value * 3.28084;
                output = `${value} Meters = ${result} Feet`;
                break;
        }

        console.log(output);
        process.exit();
    });
});
