let inches = 42;
let feet = inches / 12;
console.log(`${inches} inches = ${feet} feet`);

let lengthFeet = 60, widthFeet = 40;
let lengthMeters = lengthFeet * 0.3048;
let widthMeters = widthFeet * 0.3048;
console.log(`Plot Size in Meters: ${lengthMeters}m x ${widthMeters}m`);

let areaMeters = lengthMeters * widthMeters;
let totalAreaMeters = areaMeters * 25;
let totalAreaAcres = totalAreaMeters / 4046.86; 
console.log(`Total Area of 25 Plots: ${totalAreaAcres} acres`);
