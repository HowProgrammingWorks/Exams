// Step 3
//Renamed variables
//Formated code
'use strict'

const intersection = (firstObject, secondObject) => {
  for (let attribute_name of Object.keys(firstObject)) {
    if (firstObject[key] === secondObject[key]) {
      firstObject[key] = secondObject[key];
      } else {
      delete firstObject[key];
       }
    }
 return firstObject;
};

require('../Tests/intersection.js')(intersection);
