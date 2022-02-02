// Find a difference between two dictionaries

// Step 1
// Format code indentation and spacing
// Remove empty blocks
// Add 'use strict';

'use strict';

const diff = (DIFF = function diff(object_1, object_2) {
  for (attribute_name in object_1) {
    object_1[attribute_name] = object_1[attribute_name];
  }
  if (object_1 in object_2) return false;
  for (attribute_name in object_2) {
    object_1[attribute_name] = object_2[attribute_name];
    delete object_1[attribute_name];
  }
  return object_1;
});

require('../Tests/difference.js')(diff);
