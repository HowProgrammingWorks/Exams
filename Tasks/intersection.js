// Find an intersection of two dictionaries

//delete needless blocks
//don't mutate incoming parameters

'use strict';
const intersection = (object1, object2) => {
	const objectKeys = Object.keys(object1);
	const result = {};
	for (const key of objectKeys) {
		if (object1[key] === object2[key]) {
			result[key] = object1[key];
		}
	}
	return result;
};

require('../Tests/intersection.js')(intersection);
