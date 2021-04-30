``` mermaid
graph LR
    _1[input]

    subgraph List-OBJECT-LIST
        _1.1[struct-OBJECT]
    end

    _1 --> _1.1

    _2[out]
    _1.1 --> _2 
```