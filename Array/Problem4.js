console.log("Enter numbers separated by spaces:");

process.stdin.on('data', function (input) {
    let arr = input.toString().trim().split(/\s+/).map(Number);
    let n = arr.length;
    let found = false;

    for (let i = 0; i < n - 2; i++) {
        for (let j = i + 1; j < n - 1; j++) {
            for (let k = j + 1; k < n; k++) {
                if (arr[i] + arr[j] + arr[k] === 0) {
                    console.log(`Three Integer having sum of  ZERO: (${arr[i]}, ${arr[j]}, ${arr[k]})`);
                    found = true;
                }
            }
        }
    }

    if (!found) console.log("No triplet found");
    process.exit();
});
