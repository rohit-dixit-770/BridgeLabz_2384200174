let dogs = ["Bulldog", "Beagle", "Labrador"];

let i = 0;
let allDogs = "";

while (i < dogs.length) {
    allDogs += dogs[i++] + " ";
}
console.log("while: " + allDogs.trim());

i = 0;
allDogs = "";

do {
    allDogs += dogs[i++] + " ";
} while (i < dogs.length);

console.log("do-while: " + allDogs.trim());
