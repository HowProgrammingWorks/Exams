// Validate person name
"use strict";

const checkValidName = (T) => {
  const exceptions = [
    !T,
    T === "",
    typeof T !== "string",
    T.length === 0,
    !T.includes(" "),
  ];
  
  for (const exception of exceptions) {
    if (exception) return false;
  }

  {
    for (C of T) {
      if (C === " ") continue;
      if (
        C.toLowerCase().charCodeAt(0) >= 97 &&
        C.toLowerCase().charCodeAt(0) <= 122
      ) {
      } else {
        return false;
      }
    }
    return true;
  }
};

require("../Tests/validate.js")(checkValidName);
