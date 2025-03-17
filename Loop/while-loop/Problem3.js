let heads = 0, tails = 0;

while (heads < 11 && tails < 11) {
    let flip = Math.floor(Math.random()*10) < 5 ? "Heads" : "Tails";

    if (flip === "Heads") {
        heads++;
    } else {
        tails++;
    }

    console.log(`Flip: ${flip} - Heads: ${heads}, Tails: ${tails}`);
}

console.log(`Winner: ${heads === 11 ? "Heads" : "Tails"}`);