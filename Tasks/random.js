// Generate random integer value in given range
'use strict';

const generateRandom = (min, max) => {
    if (max === undefined){
        max = min;
        return Math.random() * (max + 1);
    }
    if (max === undefined && min === undefined) {
        return 'Data entered incorrectly.';
    }
    const random = min + Math.random() * (max - min + 1);
    return Math.floor(random);
};

const result = generateRandom(1, 9);
console.log(result);
