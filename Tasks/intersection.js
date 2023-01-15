// Find an intersection of two dictionaries
'use strict';

const intersection = (object_1, object_2) => {
  const first_keys = Object.keys(object_1);

  for (const attribute_name of first_keys) {
    const mutual = (object_1[attribute_name] === object_2[attribute_name]) ? object_2[attribute_name] = object_1[attribute_name] : delete object_1[attribute_name];
  }
  return object_1;
};

require('../Tests/intersection.js')(intersection);
