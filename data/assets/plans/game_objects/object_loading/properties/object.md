``` mermaid
graph LR
    _1[input]

    subgraph struct-OBJECT
        _1.1[string_file_name]
        _1.2[string_name]
        _1.3[int_position_in_list]
    end

    _1 --> _1.1
    _1 --> _1.2
    _1 --> _1.3

    _2[out]
    _1.1 --> _2
    _1.2 --> _2
    _1.3 --> _2  
```