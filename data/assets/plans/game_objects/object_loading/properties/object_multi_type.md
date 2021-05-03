``` mermaid
graph LR
    _1[input]

    subgraph struct-OBJECT_SINGLE_TYPE
        _1.1[string_file_name]
        _1.2[dictionary_texture_positions]
        _1.3[string_name]
        _1.4[float_global_position_in_world]
        _1.5[int_position_in_list]
        _1.6[list_object_classes]
    end

    _1 --> _1.1
    _1 --> _1.2
    _1 --> _1.3
    _1 --> _1.4
    _1 --> _1.5
    _1 --> _1.6

    _2[out]
    _1.1 --> _2
    _1.2 --> _2
    _1.3 --> _2
    _1.4 --> _2
    _1.5 --> _2
    _1.6 --> _2
```
Notes:

1.2 - texture name and position in image.

1.5 - position in object_list