let nums = [];
let len = 5;
for (let i = 0; i < len; i++) {
    nums.push(Math.floor(Math.random() * 100) + i);
}

console.log("Numbers Array: ", nums);

let min = nums[0];
let max = nums[0];

for (let i = 1; i < len; i++) {
    if (nums[i] < min) {
        min = nums[i];
    }
    if (nums[i] > max) {
        max = nums[i];
    }
}

console.log("Minimum: ", min);
console.log("Maximum: ", max);


