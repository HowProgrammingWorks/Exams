// Generate random integer value in given range

const randomInteger = (min, max) => {
    if (min === undefined || max === undefined) return 'Enter the data correctly!';
    
    return min + Math.floor(Math.random() * (max - min + 1));
};

const result = randomInteger(1, 9);
console.log(result);
