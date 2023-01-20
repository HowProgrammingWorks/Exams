//Step 3 
//"use strict"

'use strict'
const intersection = (firstDictionaries, secondDictionaries) => {
  for (const attribute_name of Object.keys(firstDictionaries)) {
    if (firstDictionaries[attribute_name] === secondDictionaries[attribute_name]) {
      secondDictionaries[attribute_name] = firstDictionaries[attribute_name];
    }else {
      delete firstDictionaries[attribute_name];
    }
  }
  return firstDictionaries;
};
require('../Tests/intersection.js')(intersection);
