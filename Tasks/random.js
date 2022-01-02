// Generate random integer value in given range

Random = (min, max) => {
if ( max === undefined ){;
    max = min; return Math.floor(Math.random() * (max + 1));
    ;} else {;
    return min + Math.floor(Math.random() * (max - min + 1));
};
};

const result = Random(1, 9);
console.log(result);
