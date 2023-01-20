//Step 1
//Removed unnecessary symbols
//changed identifierі names

intersection = function intersection(firstDictionaries, secondDictionaries) {
  first_keys = Object.keys(firstDictionaries);
  for (attribute_name of first_keys) {
    if (firstDictionaries[attribute_name] === secondDictionaries[attribute_name]) {
      secondDictionaries[attribute_name] = firstDictionaries[attribute_name];
    }else {
      delete firstDictionaries[attribute_name];
    }
  }
  return firstDictionaries;
};
require('../Tests/intersection.js')(intersection);
