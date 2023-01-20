// Step 2
//Changed function declaration for arrow expression
//Changed names for some variables
'use strict'

const intersection = (firstObject, secondObject) => {
  const first_keys = Object.keys(firstObject);
  for (let attribute_name of first_keys) {
    if (firstObject[attribute_name] === secondObject[attribute_name]) {
      firstObject[attribute_name] = secondObject[attribute_name];
      } else {
      delete firstObject[attribute_name];
       }
    }
 return firstObject;
};

require('../Tests/intersection.js')(intersection);
