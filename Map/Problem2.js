let birthMonths = new Map();

for (let i = 1; i <= 50; i++) {
    let month = Math.floor(Math.random() * 12) + 1;
    let year = Math.random() < 0.5 ? 92 : 93;
    if (!birthMonths.has(month)) {
        birthMonths.set(month, []); 
    }
    birthMonths.get(month).push(`Person${i} (Year ${year})`);
    
}

console.log("Individuals grouped by Birth Month:");
birthMonths.forEach((people, month) => console.log(`Month ${month}: ${people.join(", ")}`));
