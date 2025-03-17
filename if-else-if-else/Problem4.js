console.log("Enter three numbers separated by space:");

process.stdin.on('data', function (input) {
    let values = input.toString().trim().split(" "); 
    let a = parseInt(values[0]);
    let b = parseInt(values[1]);
    let c = parseInt(values[2]);

    let result1 = a + b * c;
    let result2 = a % b + c;
    let result3 = c + a / b;
    let result4 = a * b + c;

    console.log(`a + b * c = ${result1}`);
    console.log(`a % b + c = ${result2}`);
    console.log(`c + a / b = ${result3}`);
    console.log(`a * b + c = ${result4}`);

    let max = result1;
    if (result2 > max) max = result2;
    if (result3 > max) max = result3;
    if (result4 > max) max = result4;

    let min = result1;
    if (result2 < min) min = result2;
    if (result3 < min) min = result3;
    if (result4 < min) min = result4;

    console.log("Maximum value:", max);
    console.log("Minimum value:", min);

    process.exit(); 
});
