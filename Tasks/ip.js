// Split string by the first occurrence of separator

const splitIP = (entrStrg) => {
    extArr = [];
    if (entrStrg === '')
        return null;
    else {
        spltNums = entrStrg.split('.');
        for (let j = 0; j < spltNums.length; j++) {
            extArr[j] = parseInt(spltNums[j]);
        }
    };
    return extArr;
};

const result = splitIP('127.0.0.1');
console.log(result);

