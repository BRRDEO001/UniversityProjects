def check(pattern):
    print(pattern)
    if len(pattern) == 0:
        return "none"
    elif pattern[0] == "?":
        return "?"
    elif pattern[0] == "*":
        return "*"
    else:
        check(pattern[1::])

print(check(input("")))
