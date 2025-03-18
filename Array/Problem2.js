let arr = new Array(10);

for (let i = 0; i < 10; i++) {
    arr[i] = Math.floor(Math.random() * 100) + 100;
}

arr.sort(); 

console.log("Sorted Array:", arr);
console.log("2nd Smallest:", arr[1]);
console.log("2nd Largest:", arr[arr.length - 2]);
