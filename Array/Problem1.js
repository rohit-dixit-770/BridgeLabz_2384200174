let arr = new Array(10);

for (let i = 0; i < 10; i++) {
    arr[i] = Math.floor(Math.random() * 100) + 100;
}

console.log("Array:", arr);

let firstMax = -Infinity, secondMax = -Infinity;
let firstMin = Infinity, secondMin = Infinity;

for (let num of arr) {
    if (num > firstMax) {
        secondMax = firstMax;
        firstMax = num;
    } else if (num > secondMax && num !== firstMax) {
        secondMax = num;
    }

    if (num < firstMin) {
        secondMin = firstMin;
        firstMin = num;
    } else if (num < secondMin && num !== firstMin) {
        secondMin = num;
    }
}

console.log("2nd Largest:", secondMax);
console.log("2nd Smallest:", secondMin);
