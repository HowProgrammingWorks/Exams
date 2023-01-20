// Step 1
//Added 'use strict'
//Removed unnecessary blocks
//Added "const" and "let" to variables 
'use strict'

const intersection = function intersection(object_1, object_2) {
  const first_keys = Object.keys(object_1);
  for (let attribute_name of first_keys) {
    if (object_1[attribute_name] === object_2[attribute_name]) {
      object_2[attribute_name] = object_1[attribute_name];
      } else {
      delete object_1[attribute_name];
       }
    }
 return object_1;
};

require('../Tests/intersection.js')(intersection);
