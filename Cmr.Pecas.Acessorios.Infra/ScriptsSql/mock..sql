
--- MARCA

INSERT INTO marca (id, nome, data_insercao, data_desativacao) VALUES
('3dc3536d-f785-4050-99e8-2b54f995709f', 'TIGER AUTO', '2025-03-17', NULL),
('0e7d72f2-66e7-473a-9899-6f96211fbf05', 'RAYX', '2025-01-01', NULL),
('ca254b12-735e-4a1f-ae8c-6ee71ebe1942', 'AUTOVEX', '2024-12-22', NULL),
('46cd015e-7b20-4b57-a846-f99ca092a3ff', 'PHILIPS', '2025-01-07', NULL),
('586cc593-fb6d-41ec-b413-4ae40de61990', 'OSRAM', '2025-03-17', NULL);


--- CATEGORIA

INSERT INTO categoria (id, nome, data_insercao, data_desativacao) VALUES
('5b522eb6-f384-4f4e-b4db-c28ebd8c4a17', 'Palhetas dianteira universal', '2025-01-25', NULL),
('8f8c1124-52e6-4b0a-afa0-e8ca8ccdbbaa', 'Palhetas traseira universal', '2024-12-07', NULL),
('82905652-25d5-4024-8233-850009db855b', 'Palhetas dianteira específica', '2025-01-09', NULL),
('a45e2ac5-72ac-4981-a58f-4743e7345299', 'Palhetas traseira universal', '2025-02-13', NULL),
('9d8dd0e3-af82-4af6-930d-fcd1dd51378e', 'Lâmpadas de Led', '2024-12-01', NULL),
('0aff2359-8847-4f4e-81b6-c92acccebf33', 'Lâmpadas halogena', '2025-01-15', NULL),
('106ed72e-bb57-4d7a-9600-cb55c88a24f1', 'Tapete universal', '2025-03-26', NULL),
('ea75d6e1-5cb9-4db0-91c7-6391c25f7bf3', 'Tapete específico', '2025-03-01', NULL),
('8e9875f5-a670-4ac1-bf8f-4de95dc032ba', 'Calotas', '2024-12-20', NULL),
('7a865b85-d24e-4b54-a1b9-9e0778fae32b', 'Xenon Original', '2025-01-21', NULL),
('5bd9abca-1a7f-4371-9932-9cddd21bdc99', 'Xenon de Led', '2025-02-18', NULL),
('d67542cf-8679-4b70-b57d-99fe48c17950', 'Milha Universal', '2025-02-18', NULL),
('3c3abc84-a334-4608-a875-bad2f13b75fa', 'Fitas DRL', '2024-12-04', NULL);

-- PRODUTOS 

INSERT INTO produto (id, nome, imagem_thumbnail, descricao, estoque, id_categoria, id_marca, data_insercao, data_desativacao) VALUES
('923abc04-bcfe-4d1a-920b-a4a83d431d4a', 'Led Diamond H1', 'blue-t-shirt.jpg', 'Produto Led Diamond H1 da marca TIGER AUTO', 44, '9d8dd0e3-af82-4af6-930d-fcd1dd51378e', '3dc3536d-f785-4050-99e8-2b54f995709f', '2025-01-09', NULL),
('55406d46-6079-4211-a1f0-f316abc3eb4d', 'Led Diamond H3', 'blue-t-shirt.jpg', 'Produto Led Diamond H3 da marca TIGER AUTO', 13, '9d8dd0e3-af82-4af6-930d-fcd1dd51378e', '3dc3536d-f785-4050-99e8-2b54f995709f', '2025-01-10', NULL),
('008dd56b-c65c-4800-b4a9-7e59e64945e2', 'Led Diamond H4', 'blue-t-shirt.jpg', 'Produto Led Diamond H4 da marca TIGER AUTO', 9, '9d8dd0e3-af82-4af6-930d-fcd1dd51378e', '3dc3536d-f785-4050-99e8-2b54f995709f', '2025-03-11', NULL),
('9b1f04e6-bb01-4046-9fa7-0586e338ecdc', 'Led Diamond H7', 'blue-t-shirt.jpg', 'Produto Led Diamond H7 da marca TIGER AUTO', 39, '9d8dd0e3-af82-4af6-930d-fcd1dd51378e', '3dc3536d-f785-4050-99e8-2b54f995709f', '2024-12-10', NULL),
('8b00b655-34e9-434c-8ff3-301d38ebb5e4', 'Palheta universal dianteira 11"', 'blue-t-shirt.jpg', 'Produto Palheta universal dianteira 11" da marca TIGER AUTO', 24, '5b522eb6-f384-4f4e-b4db-c28ebd8c4a17', '3dc3536d-f785-4050-99e8-2b54f995709f', '2025-03-09', NULL),
('868d27e2-e6f4-45e7-8f80-4b8caaa16f04', 'Palheta universal dianteira 15"', 'blue-t-shirt.jpg', 'Produto Palheta universal dianteira 15" da marca TIGER AUTO', 12, '5b522eb6-f384-4f4e-b4db-c28ebd8c4a17', '3dc3536d-f785-4050-99e8-2b54f995709f', '2025-03-20', NULL),
('62a0035b-89e3-43d0-a976-0cfd7dcb8d17', 'Palheta universal dianteira 21"', 'blue-t-shirt.jpg', 'Produto Palheta universal dianteira 21" da marca TIGER AUTO', 24, '5b522eb6-f384-4f4e-b4db-c28ebd8c4a17', '3dc3536d-f785-4050-99e8-2b54f995709f', '2024-12-24', NULL),
('800069d9-d9f6-4557-a327-75dd9eca7cf8', 'Palheta universal traseira 10"', 'blue-t-shirt.jpg', 'Produto Palheta universal traseira 10" da marca TIGER AUTO', 24, '8f8c1124-52e6-4b0a-afa0-e8ca8ccdbbaa', '3dc3536d-f785-4050-99e8-2b54f995709f', '2025-03-19', NULL),
('90fb2f75-9820-4c4d-a331-e9c60c9ad954', 'Palheta universal traseira 11"', 'blue-t-shirt.jpg', 'Produto Palheta universal traseira 11" da marca TIGER AUTO', 44, '8f8c1124-52e6-4b0a-afa0-e8ca8ccdbbaa', '3dc3536d-f785-4050-99e8-2b54f995709f', '2025-03-14', NULL),
('c20c8536-e270-4a5e-8f84-83e9c576b0ef', 'Milha universal', 'blue-t-shirt.jpg', 'Produto Milha universal da marca TIGER AUTO', 29, 'd67542cf-8679-4b70-b57d-99fe48c17950', '3dc3536d-f785-4050-99e8-2b54f995709f', '2024-12-29', NULL),
('747a1e31-882e-4853-a03a-7e134acb49f9', 'Lâmpada halógena h1', 'blue-t-shirt.jpg', 'Produto Lâmpada halógena h1 da marca TIGER AUTO', 9, '0aff2359-8847-4f4e-81b6-c92acccebf33', '3dc3536d-f785-4050-99e8-2b54f995709f', '2025-01-20', NULL),
('ab120d1b-31c9-456b-893a-2fcb66f3f538', 'Lâmpada halógena h3', 'blue-t-shirt.jpg', 'Produto Lâmpada halógena h3 da marca TIGER AUTO', 26, '0aff2359-8847-4f4e-81b6-c92acccebf33', '3dc3536d-f785-4050-99e8-2b54f995709f', '2024-12-12', NULL),
('6a7326b5-4305-4568-a594-70ff451a05df', 'Lâmpada halógena h4', 'blue-t-shirt.jpg', 'Produto Lâmpada halógena h4 da marca TIGER AUTO', 26, '0aff2359-8847-4f4e-81b6-c92acccebf33', '3dc3536d-f785-4050-99e8-2b54f995709f', '2024-11-28', NULL);

--- TIPO PREÇO

INSERT INTO tipo_preco (id, nome, descricao, data_insercao, data_desativacao) VALUES
('a194760c-16f8-4e17-993f-a0f439cfabc4', 'Atacado', 'Tipo de preço: Atacado', '2024-11-27', NULL),
('51e36c08-aa00-402b-8f9d-3c19f9ab9538', 'Varejo', 'Tipo de preço: Varejo', '2024-12-11', NULL),
('6ae6cb40-5908-49f0-943c-02a80d91e40b', 'Promoção relâmpago', 'Tipo de preço: Promoção relâmpago', '2025-02-04', NULL),
('2ea80a42-16a6-48ef-a4e5-033c523181a1', 'Promoção final de ano', 'Tipo de preço: Promoção final de ano', '2025-01-25', NULL),
('6f15e65a-d3bd-45d9-a2cb-2da2249f1e4b', 'PRINCIPAL', 'Tipo de preço: Varejo', '2025-02-09', NULL),
('8d30c492-d243-479f-b1c0-3811c278aa2e', 'Promoção liquidação', 'Tipo de preço: Promoção liquidação', '2025-03-06', NULL);

--- PREÇO

INSERT INTO preco (id, preco_pj, preco_pf, id_produto, id_tipo_preco, data_insercao, data_desativacao, observacao) VALUES
('e524ff25-cadf-41df-be85-4f83a1422838', 106.04, 200.04,'923abc04-bcfe-4d1a-920b-a4a83d431d4a', '6f15e65a-d3bd-45d9-a2cb-2da2249f1e4b', '2024-12-13', NULL, 'Preço Varejo do produto Led Diamond H1'),
('3abcebde-c03b-4f5a-a753-f1fab02f745a', 146.15, 300.04,'923abc04-bcfe-4d1a-920b-a4a83d431d4a', 'a194760c-16f8-4e17-993f-a0f439cfabc4', '2025-01-20', NULL, 'Preço Atacado do produto Led Diamond H1'),
('955a77e2-7b53-4d43-bc3a-83aa21a848a2', 82.23, 160.04,'55406d46-6079-4211-a1f0-f316abc3eb4d', '6f15e65a-d3bd-45d9-a2cb-2da2249f1e4b', '2025-01-21', NULL, 'Preço Varejo do produto Led Diamond H3'),
('7cd709aa-4f26-4b12-98c0-b72fd61230c6', 89.5, 160.04,'55406d46-6079-4211-a1f0-f316abc3eb4d', 'a194760c-16f8-4e17-993f-a0f439cfabc4', '2025-01-10', NULL, 'Preço Atacado do produto Led Diamond H3'),
('356801a0-663c-42c5-a18d-f1468849c407', 69.97, 170.04,'008dd56b-c65c-4800-b4a9-7e59e64945e2', '6f15e65a-d3bd-45d9-a2cb-2da2249f1e4b', '2024-12-20', '2024-12-21', 'Preço Varejo do produto Led Diamond H4'),
('b5cef998-4a8a-40fd-a9c8-ea9fe6a17c8a', 75.8, 150.04,'008dd56b-c65c-4800-b4a9-7e59e64945e2', 'a194760c-16f8-4e17-993f-a0f439cfabc4', '2025-02-18', NULL, 'Preço Atacado do produto Led Diamond H4'),
('a8e7aa6f-13a0-487f-b505-4b8611072305', 99.93, 200.04,'9b1f04e6-bb01-4046-9fa7-0586e338ecdc', '6f15e65a-d3bd-45d9-a2cb-2da2249f1e4b', '2025-02-17', NULL, 'Preço Varejo do produto Led Diamond H7'),
('0c783013-4437-4336-8b96-8e6d80eb124e', 139.58, 230.04,'9b1f04e6-bb01-4046-9fa7-0586e338ecdc', 'a194760c-16f8-4e17-993f-a0f439cfabc4', '2024-12-18', NULL, 'Preço Atacado do produto Led Diamond H7'),
('b1dc6365-c4bb-49d6-8b21-21f8b3902a79', 45.62, 90.04,'8b00b655-34e9-434c-8ff3-301d38ebb5e4', '6f15e65a-d3bd-45d9-a2cb-2da2249f1e4b', '2024-12-14', NULL, 'Preço Varejo do produto Palheta universal dianteira 11"'),
('559f9f1e-be79-413e-8f35-059e1fbd4578', 117.68, 250.04,'8b00b655-34e9-434c-8ff3-301d38ebb5e4', 'a194760c-16f8-4e17-993f-a0f439cfabc4', '2025-01-19', NULL, 'Preço Atacado do produto Palheta universal dianteira 11"'),
('c1e866a8-7127-45b8-bae7-9e200cd9778e', 97.21, 150.04,'868d27e2-e6f4-45e7-8f80-4b8caaa16f04', '6f15e65a-d3bd-45d9-a2cb-2da2249f1e4b', '2025-01-12', NULL, 'Preço Varejo do produto Palheta universal dianteira 15"'),
('cdf0ef30-51d0-4828-b610-47b7db7d06e9', 123.89, 320.04,'868d27e2-e6f4-45e7-8f80-4b8caaa16f04', 'a194760c-16f8-4e17-993f-a0f439cfabc4', '2025-03-21', NULL, 'Preço Atacado do produto Palheta universal dianteira 15"'),
('93822c4f-0e39-4760-b0ad-a2e4fa2f62af', 92.29, 188.04,'62a0035b-89e3-43d0-a976-0cfd7dcb8d17', '6f15e65a-d3bd-45d9-a2cb-2da2249f1e4b', '2025-01-13', NULL, 'Preço Varejo do produto Palheta universal dianteira 21"'),
('2543cd5d-d212-4347-bd5c-8246abe09874', 92.89, 196.04,'62a0035b-89e3-43d0-a976-0cfd7dcb8d17', 'a194760c-16f8-4e17-993f-a0f439cfabc4', '2025-01-28', NULL, 'Preço Atacado do produto Palheta universal dianteira 21"'),
('c75ce8d1-6e9c-4ee6-ac69-c26a293fdb1a', 147.34, 290.04,'800069d9-d9f6-4557-a327-75dd9eca7cf8', '6f15e65a-d3bd-45d9-a2cb-2da2249f1e4b', '2024-12-12', NULL, 'Preço Varejo do produto Palheta universal traseira 10"'),
('1d23ff83-946e-4158-8cdf-9195657ca5f4', 120.66, 280.04,'800069d9-d9f6-4557-a327-75dd9eca7cf8', 'a194760c-16f8-4e17-993f-a0f439cfabc4', '2025-02-06', NULL, 'Preço Atacado do produto Palheta universal traseira 10"'),
('2048ec0e-8364-4c63-9cd9-167cbaf0d4b4', 110.64, 260.04,'90fb2f75-9820-4c4d-a331-e9c60c9ad954', '6f15e65a-d3bd-45d9-a2cb-2da2249f1e4b', '2025-01-30', NULL, 'Preço Varejo do produto Palheta universal traseira 11"'),
('29b61fa1-de7f-4e14-a8c2-0df4e71f39e6', 98.36, 193.04,'90fb2f75-9820-4c4d-a331-e9c60c9ad954', 'a194760c-16f8-4e17-993f-a0f439cfabc4', '2024-12-15', NULL, 'Preço Atacado do produto Palheta universal traseira 11"'),
('5faaf8aa-3b62-44a5-a334-9ac9beb6ac1d', 80.98, 187.04,'c20c8536-e270-4a5e-8f84-83e9c576b0ef', '6f15e65a-d3bd-45d9-a2cb-2da2249f1e4b', '2025-01-12', NULL, 'Preço Varejo do produto Milha universal'),
('e733dd3c-606b-4f7a-b0f9-cae082df448a', 121.93, 350.04,'c20c8536-e270-4a5e-8f84-83e9c576b0ef', 'a194760c-16f8-4e17-993f-a0f439cfabc4', '2025-01-17', NULL, 'Preço Atacado do produto Milha universal'),
('6a7bb24b-9678-49ab-8173-8d780be50773', 95.24, 174.04,'747a1e31-882e-4853-a03a-7e134acb49f9', '6f15e65a-d3bd-45d9-a2cb-2da2249f1e4b', '2025-01-26', NULL, 'Preço Varejo do produto Lâmpada halógena h1'),
('1098206f-00ed-4096-b45f-1ffbbbeada29', 125.7, 199.04,'747a1e31-882e-4853-a03a-7e134acb49f9', 'a194760c-16f8-4e17-993f-a0f439cfabc4', '2025-02-14', NULL, 'Preço Atacado do produto Lâmpada halógena h1'),
('f148315b-9299-4919-9996-8340b4f422d9', 78.69, 180.04,'ab120d1b-31c9-456b-893a-2fcb66f3f538', '6f15e65a-d3bd-45d9-a2cb-2da2249f1e4b', '2025-01-11', NULL, 'Preço Varejo do produto Lâmpada halógena h3'),
('6c94f290-d181-41d9-93ca-f99e647847d1', 32.79, 70.04,'ab120d1b-31c9-456b-893a-2fcb66f3f538', 'a194760c-16f8-4e17-993f-a0f439cfabc4', '2024-12-01', NULL, 'Preço Atacado do produto Lâmpada halógena h3'),
('a2342078-543f-442c-9435-b6eb5971dc40', 53.86, 100.04,'6a7326b5-4305-4568-a594-70ff451a05df', '6f15e65a-d3bd-45d9-a2cb-2da2249f1e4b', '2025-02-23', NULL, 'Preço Varejo do produto Lâmpada halógena h4'),
('ff20b258-6177-4363-a4c5-c9befbe4d5d2', 62.13, 133.04,'6a7326b5-4305-4568-a594-70ff451a05df', 'a194760c-16f8-4e17-993f-a0f439cfabc4', '2025-02-28', NULL, 'Preço Atacado do produto Lâmpada halógena h4');

--- CUSTO

INSERT INTO custo (id, id_produto, nome, descricao, custo, data_insercao, data_desativacao) VALUES
('5ae15002-535a-4c41-9afa-c43faae44aef', '923abc04-bcfe-4d1a-920b-a4a83d431d4a', 'Fornecedor TIGER AUTO', 'Lote de compra para Led Diamond H1', 40.34, '2025-02-22', NULL),
('a729be09-37e2-4305-8ad1-971d477e4cb9', '55406d46-6079-4211-a1f0-f316abc3eb4d', 'Fornecedor TIGER AUTO', 'Lote de compra para Led Diamond H3', 55.78, '2024-12-05', NULL),
('f750885c-29a6-4384-9c1b-bf2197204c8f', '008dd56b-c65c-4800-b4a9-7e59e64945e2', 'Fornecedor TIGER AUTO', 'Lote de compra para Led Diamond H4', 55.4, '2025-01-24', NULL),
('3d0fc35d-70e0-40d4-8149-ad85e435108e', '9b1f04e6-bb01-4046-9fa7-0586e338ecdc', 'Fornecedor TIGER AUTO', 'Lote de compra para Led Diamond H7', 29.01, '2024-12-11', NULL),
('b515b298-4760-494d-8c82-04f1f1450c86', '8b00b655-34e9-434c-8ff3-301d38ebb5e4', 'Fornecedor TIGER AUTO', 'Lote de compra para Palheta universal dianteira 11"', 47.73, '2025-03-17', NULL),
('0dbc8327-d8a4-46ff-a871-8d0f0cb6444d', '868d27e2-e6f4-45e7-8f80-4b8caaa16f04', 'Fornecedor TIGER AUTO', 'Lote de compra para Palheta universal dianteira 15"', 39.26, '2024-12-02', NULL),
('226ecee0-c758-4ba7-9cf4-058ab580761d', '62a0035b-89e3-43d0-a976-0cfd7dcb8d17', 'Fornecedor TIGER AUTO', 'Lote de compra para Palheta universal dianteira 21"', 68.63, '2024-12-23', NULL),
('11a3db84-f2b5-4693-9cd4-ff314938f264', '800069d9-d9f6-4557-a327-75dd9eca7cf8', 'Fornecedor TIGER AUTO', 'Lote de compra para Palheta universal traseira 10"', 60.72, '2025-01-07', NULL),
('ad2efbf2-3321-4e69-a59f-5213d95d7c6c', '90fb2f75-9820-4c4d-a331-e9c60c9ad954', 'Fornecedor TIGER AUTO', 'Lote de compra para Palheta universal traseira 11"', 42.47, '2024-12-04', NULL),
('19153348-87a0-4795-84cd-679805a61104', 'c20c8536-e270-4a5e-8f84-83e9c576b0ef', 'Fornecedor TIGER AUTO', 'Lote de compra para Milha universal', 35.76, '2024-12-27', NULL),
('f6fb6144-7838-43ca-9b87-f1b75a3e7f31', '747a1e31-882e-4853-a03a-7e134acb49f9', 'Fornecedor TIGER AUTO', 'Lote de compra para Lâmpada halógena h1', 13.5, '2024-12-20', NULL),
('5ee0e8ad-7014-495c-bc25-f1517bf8fddf', 'ab120d1b-31c9-456b-893a-2fcb66f3f538', 'Fornecedor TIGER AUTO', 'Lote de compra para Lâmpada halógena h3', 44.15, '2025-03-28', NULL),
('1fb17780-d1a1-46e6-a298-5047cc9c31a8', '6a7326b5-4305-4568-a594-70ff451a05df', 'Fornecedor TIGER AUTO', 'Lote de compra para Lâmpada halógena h4', 28.08, '2025-02-25', NULL);

--- MARGEM LUCRO

INSERT INTO margem_lucro (id, porcentagem_pj, porcentagem_pf, valor_liquido_pj, valor_liquido_pf, id_preco, data_insercao, data_desativacao) VALUES
('3b4f106a-be08-450e-b86f-20058d40753d', 32.64, 60.64, 20.64, 30.64,'e524ff25-cadf-41df-be85-4f83a1422838', '2024-12-13', NULL),
('f23ccdf4-0e38-4bae-afc5-31bec7952596', 34.85, 80.64, 15.64, 25.64,'3abcebde-c03b-4f5a-a753-f1fab02f745a', '2025-01-20', NULL),
('bf9bc0df-69f2-426c-8c62-105a6498c499', 38.94, 90.64, 20.64, 35.64,'955a77e2-7b53-4d43-bc3a-83aa21a848a2', '2025-01-21', NULL),
('bba9ae21-9a9e-4cc2-b950-ba0ef160d1a1', 39.11, 77.64, 15.64, 45.64,'7cd709aa-4f26-4b12-98c0-b72fd61230c6', '2025-01-10', NULL),
('62d0d2c0-73ad-48be-a2a4-92f82f9881fd', 17.94, 60.64, 10.64, 30.64,'356801a0-663c-42c5-a18d-f1468849c407', '2024-12-20', NULL),
('3fb21b3b-a345-4ce8-82b7-7efa4d3c5e24', 35.66, 70.64, 15.64, 35.64,'b5cef998-4a8a-40fd-a9c8-ea9fe6a17c8a', '2025-02-18', NULL),
('fb6d48f9-322b-4d2c-9989-af01119c3976', 26.09, 90.64, 12.64, 40.64,'a8e7aa6f-13a0-487f-b505-4b8611072305', '2025-02-17', NULL),
('26e6148a-a8ce-4662-af94-a9a99870f622', 21.61, 55.64, 10.64, 25.64,'0c783013-4437-4336-8b96-8e6d80eb124e', '2024-12-18', NULL),
('6c55cf76-8060-4468-b247-e7ebbccff873', 17.47, 97.64, 7.64, 45.64,'b1dc6365-c4bb-49d6-8b21-21f8b3902a79', '2024-12-14', NULL),
('e9808fb9-1045-4f2c-9bcb-49630c52476a', 30.79, 55.64, 12.64, 25.64,'559f9f1e-be79-413e-8f35-059e1fbd4578', '2025-01-19', NULL),
('9c62db31-2fef-4919-83cc-5a59129ba524', 32.53, 60.64, 13.64, 30.64,'c1e866a8-7127-45b8-bae7-9e200cd9778e', '2025-01-12', NULL),
('04cadd82-e49a-4cd0-88b5-3357651b7ff8', 31.6, 45.64, 23.64, 34.64,'cdf0ef30-51d0-4828-b610-47b7db7d06e9', '2025-03-21', NULL),
('634938ec-d643-475d-b0f7-30ff5eb44b87', 36.71, 77.64, 14.64, 45.64,'93822c4f-0e39-4760-b0ad-a2e4fa2f62af', '2025-01-13', NULL),
('ac8d8f25-6dbe-4589-8b96-ec371fa60ec9', 19.93, 55.64, 11.64, 22.64,'2543cd5d-d212-4347-bd5c-8246abe09874', '2025-01-28', NULL),
('d82b4dca-cb7e-4b82-bc5e-73d14dfed71d', 36.09, 68.64, 16.64, 32.64,'c75ce8d1-6e9c-4ee6-ac69-c26a293fdb1a', '2024-12-12', NULL),
('3ca3178c-0da8-4067-b1f4-fea895b28930', 47.55, 85.64, 20.64, 42.64,'1d23ff83-946e-4158-8cdf-9195657ca5f4', '2025-02-06', NULL),
('0e82f4c4-59b8-41a6-8bc8-32b86f04706e', 28.77, 69.64, 13.64, 32.64,'2048ec0e-8364-4c63-9cd9-167cbaf0d4b4', '2025-01-30', NULL),
('43334f34-39bf-46b4-8227-c027532ea836', 33.21, 66.64, 10.64, 31.64,'29b61fa1-de7f-4e14-a8c2-0df4e71f39e6', '2024-12-15', NULL),
('a39a6543-051c-46f0-8c06-0857be72ae46', 39.41, 74.64, 16.64, 36.64,'5faaf8aa-3b62-44a5-a334-9ac9beb6ac1d', '2025-01-12', NULL),
('e4df1dc8-c43e-48cf-a068-1c34db9cbe42', 38.94, 69.64, 18.64, 30.64,'e733dd3c-606b-4f7a-b0f9-cae082df448a', '2025-01-17', NULL),
('4ba29140-f947-4599-962b-4c9e38d071b7', 10.51, 67.64, 5.64, 32.64,'6a7bb24b-9678-49ab-8173-8d780be50773', '2025-01-26', NULL),
('c1cc1137-a194-4bca-a93d-46a9df3e2162', 42.14, 80.64, 21.64, 65.64,'1098206f-00ed-4096-b45f-1ffbbbeada29', '2025-02-14', NULL),
('32595fde-501f-4e78-9a4d-01e2ea55a36f', 28.86, 87.64, 16.64, 49.64,'f148315b-9299-4919-9996-8340b4f422d9', '2025-01-11', NULL),
('b62b59d4-8eb1-4d46-9546-6a57079794a2', 42.38, 84.64, 21.64, 55.64,'6c94f290-d181-41d9-93ca-f99e647847d1', '2024-12-01', NULL),
('9fd8da9c-ccf9-41db-b6f5-59b3d249386e', 27.14, 54.64, 15.64, 25.64,'a2342078-543f-442c-9435-b6eb5971dc40', '2025-02-23', NULL),
('adae4244-78dd-4a53-96c5-989e3efa0d3c', 34.58, 69.64, 15.64, 21.64,'ff20b258-6177-4363-a4c5-c9befbe4d5d2', '2025-02-28', NULL);

-- CLIENTES

INSERT INTO cliente (id, nome, data_insercao, data_desativacao, observacao)
VALUES 
  ('11111111-1111-1111-1111-111111111111', 'João da Silva', CURRENT_DATE, NULL, 'Cliente antigo e fiel'),
  ('22222222-2222-2222-2222-222222222222', 'Maria Oliveira', CURRENT_DATE, NULL, 'Comprou recentemente'),
  ('33333333-3333-3333-3333-333333333333', 'Carlos Souza', CURRENT_DATE, NULL, 'Cliente VIP'),
  ('44444444-4444-4444-4444-444444444444', 'Fernanda Lima', CURRENT_DATE, NULL, 'Prefere contato por WhatsApp'),
  ('55555555-5555-5555-5555-555555555555', 'Ana Beatriz Costa', CURRENT_DATE, NULL, 'Solicita orçamento mensal');