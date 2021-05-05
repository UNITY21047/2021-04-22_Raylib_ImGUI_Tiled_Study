``` mermaid
graph LR
    _1[input]

    subgraph List-object_list
        _1.1[struct-object]
    end

    _1 --> _1.1

    _2[out]
    _1.1 --> _2 
```