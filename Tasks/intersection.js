//Step 2
//added const let for variables
//changed function declaration for arrow expression

const intersection = (firstDictionaries, secondDictionaries) => {
  const first_keys = Object.keys(firstDictionaries);
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
