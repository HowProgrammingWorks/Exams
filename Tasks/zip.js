// Zip two arrays, [1, 2] and [3, 4] -> [[1, 3], [2, 4]]
'use strict';

const zip = (arrayA = [], arrayB = []) => {

  const firstArray = arrayA.slice(0);
  const arrayResult = arrayB.slice(0);

  let indexArr = 0;
  let indexRes = 0;

  for (const element of arrayResult) {

  const cell = [firstArray[indexArr++], element];

    if (indexArr < indexRes) firstArray.pop();
    
    else  arrayResult[indexRes++] = cell;
    
    if (cell[0] === undefined) arrayResult.pop();
  }

  return arrayResult;
};

require('../Tests/zip.js')(zip);
