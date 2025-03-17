let n = parseInt(process.argv[2]);

for (let i = 0, power = 1; i <= n; i++, power *= 2) {
    console.log(`2^${i} = ${power}`);
}


