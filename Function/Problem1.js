function convertTemperature(choice, temp) {
    switch (choice) {
        case 'CtoF': 
            if (temp < 0 || temp > 100) {
                console.log("Invalid input: Temperature should be between 0 degC and 100 degC");
                return;
            }
            console.log(`${temp}°C = ${(temp * 9 / 5 + 32).toFixed(2)}°F`);
            break;

        case 'FtoC': 
            if (temp < 32 || temp > 212) {
                console.log("Invalid input: Temperature should be between 32 degF and 212 degF");
                return;
            }
            console.log(`${temp}degF = ${((temp - 32) * 5 / 9).toFixed(2)}degC`);
            break;

        default:
            console.log("Invalid choice! Use 'CtoF' or 'FtoC'");
    }
}

console.log("Enter conversion type (CtoF or FtoC) followed by temperature :");

process.stdin.on('data', function(input) {
    let args = input.toString().trim().split(" ");
    let choice = args[0];  
    let temp = parseFloat(args[1]);

    convertTemperature(choice, temp);
    process.exit();
});
