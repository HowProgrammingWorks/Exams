// Generate random integer value in given range
'use strict';

const generateRandom = (minValue, maxValue) => {
    if (maxValue === undefined){
        maxValue = minValue;
        return Math.random() * (maxValue + 1);
    }
    if (maxValue === undefined && minValue === undefined) {
        return 'Data entered incorrectly.';
    }
    const random = minValue + Math.random() * (maxValue - minValue + 1);
    return Math.floor(random);
};

const result = generateRandom(1, 9);
console.log(result);
