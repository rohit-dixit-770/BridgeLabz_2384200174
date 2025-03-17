let dogs = ["Bulldog", "Beagle", "Labrador"];

let allDogs = "";
for (let i = 0; i < dogs.length; i++) {
    allDogs += dogs[i] + " ";
}
console.log("OLD: " + allDogs.trim());

allDogs = "";
for (let dog of dogs) {
    allDogs += dog + " ";
}
console.log("NEW: " + allDogs.trim());

console.log("BEST: " + dogs.join(" "));
