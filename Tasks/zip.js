// Zip two arrays, [1, 2] and [3, 4] -> [[1, 3], [2, 4]]
'use strict';

const zip = (arrayA = [], arrayB = []) => {

  const array1 = arrayA.slice(0);
  const array2 = arrayB.slice(0);

  let indexA = 0;
  let indexB = 0;

  for (const element of array2) {

    const cell = [array1[indexA++], element];

    if (indexA < indexB)  delete array1[indexA++];
    
    else  array2[indexB++] = cell;
    
    if (cell[0] === undefined) array2.length -= 1;
  }

  return array2;
};

require('../Tests/zip.js')(zip);
