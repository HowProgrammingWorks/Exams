def difference(FirstObject, SecondObject):
    if FirstObject == SecondObject:
        return False
    FirstDiff = FirstObject.keys() - SecondObject.keys()
    FirstDiffResult = {k: FirstObject[k] for k in FirstDiff}
    SecondDiff = SecondObject.keys() - FirstObject.keys()
    SecondDiffResult = {k: SecondObject[k] for k in SecondDiff}
    return FirstDiffResult, SecondDiffResult
result = difference({ 'a': 'uno', 'b': 'due' }, { 'a': 'uno', 'c': 'tre' })
print(result)